using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    //Fábrica Concreta (Concrete Factory)
    public class OracleFactory : DBFactory
    {
        public override DBConnection createConnection()
        {
            return new OracleConnection();
        }

        public override DBCommand createCommand()
        {
            return new OracleCommand();
        }
    }
}
