using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class DataSetDecorator : BaseDataSet // herança
    {
        protected BaseDataSet _basedataset;

        public void setDatasetbase(BaseDataSet basedataset)
        {
            this._basedataset = basedataset;
        }

        public override void Write()
        {
            Console.WriteLine("Método DataSetDecorator.Write() invocado");
            this._basedataset.Write();
        }
    }
}
