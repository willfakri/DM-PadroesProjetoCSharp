using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesTreino
{
    public class Documento: Arquivo, IImprimivel
    {
        public override void Abrir()
        {
            base.Abrir();
            Console.WriteLine("Exibindo documento " + Nome);
        }

        public void Imprimir()
        {
            Console.WriteLine("Imprimindo documento " + Nome);
        }
    }
}
