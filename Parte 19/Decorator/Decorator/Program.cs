using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class Program
    {
        // Client
        static void Main(string[] args)
        {
            // Cria ConcreteComponent
            DataSet c = new DataSet();
            // Cria ConcreteDecorator
            DataSetConcreteDecorator d = new DataSetConcreteDecorator();
            // setando objeto a ser decorado (injetando implementaçã0)
            d.setDatasetbase(c);
            // chamando método da abstração
            d.Write();
            // chamando método injetado pelo decorator
            d.WriteXML();
            Console.ReadLine();
        }
    }
}
