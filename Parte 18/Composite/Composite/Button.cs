using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    // Leaf
    public class Button : Component
    {
        public Button(string name)
            : base(name)
        {
        }

        public override void Add(Component c)
        {
            Console.WriteLine("Não é possível adicionar elementos a este componente");
        }
        
        public override void Remove(Component c)
        {
            Console.WriteLine("Não é possível remover elemento");
        }

        public override void Display()
        {
            Console.WriteLine(_name);
        }
    }
}
