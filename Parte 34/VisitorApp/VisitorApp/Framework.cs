using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorApp
{
    //Visitor
    public abstract class Visitor
    {
        public abstract void VisitConcreteElementA(
            ConcreteElementA concreteElementA);
        public abstract void VisitConcreteElementB(
            ConcreteElementB concreteElementB);
    }

    //Concrete Visitor 1
    public class ConcreteVisitor1 : Visitor
    {
        public override void VisitConcreteElementA(ConcreteElementA concreteElementA)
        {
            Console.WriteLine("{0} visitado por {1}", concreteElementA.GetType().Name, this.GetType().Name);
        }

        public override void VisitConcreteElementB(ConcreteElementB concreteElementB)
        {
            Console.WriteLine("{0} visitado por {1}", concreteElementB.GetType().Name, this.GetType().Name);
        }
    }

    public class ConcreteVisitor2 : Visitor
    {
        public override void VisitConcreteElementA(ConcreteElementA concreteElementA)
        {
            Console.WriteLine("{0} visitado por {1}", concreteElementA.GetType().Name, this.GetType().Name);
        }

        public override void VisitConcreteElementB(ConcreteElementB concreteElementB)
        {
            Console.WriteLine("{0} visitado por {1}", concreteElementB.GetType().Name, this.GetType().Name);
        }
    }

    public class ConcreteElementA
    {
    }

    public class ConcreteElementB
    {
    }
}
