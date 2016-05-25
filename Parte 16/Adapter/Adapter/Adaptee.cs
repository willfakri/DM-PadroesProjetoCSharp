using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    public class Adaptee
    {
        // interface diferente de request
        public void SpecificRequest()
        {
            Console.WriteLine("Método SpecificRequest de Adaptee chamado");
        }
    }
}
