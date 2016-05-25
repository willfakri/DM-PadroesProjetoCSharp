using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    //Concrete Product
    public class OracleConnection : DBConnection
    {
        public override void Open()
        {
            Console.WriteLine("Método Open de OracleConnection foi chamado");
        }
    }
}
