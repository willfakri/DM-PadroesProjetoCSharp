using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    // Concrete Component
    public class DataSet : BaseDataSet
    {
        public override void Write()
        {
            // salvar dados do dataset
            Console.WriteLine("Método DataSet.Write() invocado");
        }
    }
}
