using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class DataSetConcreteDecorator : DataSetDecorator
    {
        public override void Write()
        {
            Console.WriteLine("Método DataSetConcreteDecorator.Write() invocado");
            this._basedataset.Write();
        }
        // decorando novas funcionalidades
        public void WriteXML()
        {
            Console.WriteLine("Método DataSetConcreteDecorator.WriteXML() invocado");
        }
    }
}
