using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = new Email();
            email.Enviar("Olá, mundo");
            Console.ReadLine();
        }
    }
}
