using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var con1 = ConexaoBD.Instance();
            con1.stringConexao = "SQL Server";
            con1.Open();
            var con2 = ConexaoBD.Instance();
            con2.Open();
            // comprovando que são a mesma instância
            if (con1 == con2) // está apontando a mesma posição de memória, apontando para o mesmo objeto
                Console.WriteLine("São a mesma instância");
            Console.ReadLine();

        }
    }
}
