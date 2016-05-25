using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    // transforma Adaptee num Target
    public class Adapter:Target
    {
        // composição simples
        private Adaptee _adaptee = new Adaptee();

        // delegação simples repassa a chamada ao adaptee
        public override void Request()
        {
            // chamada de método de interface diferente
            _adaptee.SpecificRequest();
        }
    }
}
