using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heranca
{
    public class Aluno:Pessoa
    {
        public int Matricula;
        public void Estudar()
        {
            Console.WriteLine(Nome + " estudando...");
        }
    }
}
