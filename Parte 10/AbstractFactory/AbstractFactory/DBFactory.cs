﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    //Fábrica Abstrata (Abstract Factory)
    public abstract class DBFactory
    {
        public abstract DBConnection createConnection();
        public abstract DBCommand createCommand();
    }
}
