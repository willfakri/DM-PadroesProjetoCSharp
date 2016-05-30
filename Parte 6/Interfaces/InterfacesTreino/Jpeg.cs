using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesTreino
{
    public class Jpeg: Arquivo, IImprimivel
    {
        public override void Abrir()
        {
            base.Abrir();
            Console.WriteLine("Visualizando imagem " + Nome);
        }

        public void Imprimir()
        {
            Console.WriteLine("Imprimindo imagem " + Nome);
        }
    }
}
