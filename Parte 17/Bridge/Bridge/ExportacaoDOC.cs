using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    // ConcreteImplementor
    public class ExportacaoDOC : ExportacaoImpl
    {
        public override void Exportar()
        {
            Console.WriteLine("Exportando DOC...");
        }
    }
}
