using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    public class ExportacaoPDF : ExportacaoImpl
    {
        public override void Exportar()
        {
            Console.WriteLine("Exportando PDF...");
        }
    }
}
