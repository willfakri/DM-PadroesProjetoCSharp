using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // configurar a estrutura
            ObjectStrutcture obj = new ObjectStrutcture();
            obj.Attach(new ConcreteElementA());
            obj.Attach(new ConcreteElementB());

            // criar os visitors
            ConcreteVisitor1 v1 = new ConcreteVisitor1();
            ConcreteVisitor2 v2 = new ConcreteVisitor2();

            // estrutura aceitar visitors
            obj.Accept(v1);
            obj.Accept(v2);

            Console.ReadLine();
        }
    }
}
