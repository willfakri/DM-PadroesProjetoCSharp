using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    //Fábrica Concreta (Concrete Factory)
    public class SQLFactory: DBFactory
    {
        public override DBConnection createConnection()
        {
            return new SQLConnection();
        }

        public override DBCommand createCommand()
        {
            return new SQLCommand();
        }
    }
}
