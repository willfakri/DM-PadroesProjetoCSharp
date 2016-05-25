using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente chefe = new Gerente();
            chefe.Trabalhar("Sistema atendimento ao usuário");
            Console.ReadLine();
        }
    }
}
