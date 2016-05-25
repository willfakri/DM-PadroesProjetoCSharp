using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heranca
{
    public class Funcionario:Pessoa
    {
        public string Departamento;
        public void Trabalhar()
        {
            Console.WriteLine(Nome + " trabalhando...");
        }

    }
}
