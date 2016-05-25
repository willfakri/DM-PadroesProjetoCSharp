using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        // Client
        static void Main(string[] args)
        {
            Correcao prova = new CorrecaoProva();
            prova.Processar();
            Correcao redacao = new CorrecaoRedacao();
            redacao.Processar();
            Console.ReadLine();
        }
    }
}
