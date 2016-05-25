using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        // Client
        static void Main(string[] args)
        {
            // cria um array com 20 números randomizados
            long[] inputArray = new long[20];

            Random rnd = new Random();
            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] = rnd.Next(100);
            }
            // mostra os números desordenados
            Console.WriteLine("Números originais:");
            foreach (var number in inputArray)
                Console.WriteLine(number);            
            Console.ReadLine();
            // usando a estratégia para ordenar...
            Context ctx = new Context(new InsertionSort());
            ctx.ContextInterface(inputArray);
            // mostra números ordenados
            Console.WriteLine("Números ordenados:");
            foreach (var number in inputArray)
                Console.WriteLine(number);
            Console.ReadLine();
        }
    }
}
