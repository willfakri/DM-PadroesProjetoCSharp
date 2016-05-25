using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    class Program
    {
        // Client
        static void Main(string[] args)
        {
            Exportacao exp = new ExportacaoEx();
            // injetando o objeto de implementação
            exp.Implementor = new ExportacaoPDF();
            exp.Exportar();
            Console.ReadLine();
        }
    }
}
