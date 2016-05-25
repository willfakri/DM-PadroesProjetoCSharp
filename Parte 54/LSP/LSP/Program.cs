using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            var pj = new PessoaJuridica() { Nome = "GPauli", RazaoSocial = "Guinther Pauli" };
            var pf = new PessoaFisica() { Nome = "Guinther Pauli", CPF = "123" };
            var imp = new Impressao();
            imp.Impmrimir(pj);
            Console.ReadLine();

        }
    }
}
