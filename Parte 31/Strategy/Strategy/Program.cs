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
            long[] inputArray = new long[20];

            Random rnd = new Random();
            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] = rnd.Next(100);
            }
            Console.WriteLine("Números originais:");
            foreach (var number in inputArray)
                Console.WriteLine(number);            
            Console.ReadLine();
            // ordena
            var alg = new SelectionSort();
            alg.Sort(inputArray);
            Console.WriteLine("Números ordenados:");
            foreach (var number in inputArray)
                Console.WriteLine(number);
            Console.ReadLine();
        }
    }
}
