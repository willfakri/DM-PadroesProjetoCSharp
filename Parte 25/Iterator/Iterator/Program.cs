using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria Concrete Aggregate
            Equipe equipe = new Equipe();
            equipe[0] = "Guinther";
            equipe[1] = "Paulo";
            equipe[2] = "Luciano";
            equipe[3] = "Wesley";

            // Cria Iterator
            ConcreteIterator i = new ConcreteIterator(equipe);

            // iterar pela coleção
            Console.WriteLine("Listando membros da equipe:");
            Object item = i.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }
            Console.ReadLine();
        }
    }
}
