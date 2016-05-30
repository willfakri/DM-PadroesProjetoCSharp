using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesTreino
{
    public abstract class Arquivo
    {
        public string Nome { get; set; }

        public double TamanhoMB { get; set; }

        public virtual void Abrir()
        {
            Console.WriteLine("Abrindo o arquivo " + Nome + " ...");
        }
    }
}