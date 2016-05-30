using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegacaoTreino
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente gerenteDinossauro = new Gerente();
            gerenteDinossauro.Trabalhar("relatório de apontamentos");

            Console.ReadKey();
        }
    }
}
