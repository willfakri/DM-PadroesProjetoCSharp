using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    // Composite
    public class Formulario : Component
    {
        private List<Component> _children = new List<Component>();

        public Formulario(string name)
            : base(name)
        {
        }

        public override void Add(Component c)
        {
            this._children.Add(c);
        }

        public override void Remove(Component c)
        {
            this._children.Remove(c);
        }

        public override void Display()
        {
            Console.WriteLine(_name);
            foreach (var c in _children)
            {
                c.Display();
            }
        }
    }
}
