using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    //Concrete Product
    public class SQLCommand:DBCommand
    {
        public override void Execute()
        {
            Console.WriteLine("Método Execute de SQLCommand foi chamado");
        }
    }
}
