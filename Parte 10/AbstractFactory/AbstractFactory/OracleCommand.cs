using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    //Concrete Product
    public class OracleCommand : DBCommand
    {
        public override void Execute()
        {
            Console.WriteLine("Método Execute de OracleCommand foi chamado");
        }
    }
}
