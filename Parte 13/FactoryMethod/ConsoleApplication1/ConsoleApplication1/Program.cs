using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    // Client
    class Program
    {
        static void Main(string[] args)
        {
            Creator[] creators = new Creator[2];
            creators[0] = new FacebookCreator();
            creators[1] = new GoogleCreator();

            foreach (Creator c in creators)
            {
                Autenticacao aut = c.CreateInstance();
                aut.Autenticar();
            }
            Console.ReadLine();
        }
    }
}
