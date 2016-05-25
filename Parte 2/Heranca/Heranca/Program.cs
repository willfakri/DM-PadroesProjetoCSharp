using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno gp = new Aluno();
            gp.Matricula = 123;
            gp.Nome = "Guinther";
            gp.Estudar();
            gp.Dormir();
            Funcionario rp = new Funcionario();
            rp.Departamento = "Desenvolvimento";
            rp.Nome = "Rudolfo";
            rp.Trabalhar();
            rp.Dormir();
            Console.ReadLine();
        }
    }
}
