using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoC
{
    class Program
    {
        static void Main(string[] args)
        {
            var gp = new Funcionario();
            gp.Codigo = 123;
            gp.Nome = "Guinther Pauli";
            gp.Salario = 1000;
            gp.DataAdmissao = new DateTime(2000, 04, 29);
            gp.AumentarSalario(20);
            gp.Imprimir();
            var tempo = gp.CalcularTempoServico();
            Console.WriteLine("Tempo de serviço: " + tempo);
            Console.ReadLine();
        }
    }
}
