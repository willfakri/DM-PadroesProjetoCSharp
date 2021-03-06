﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    // ConcreteHandler
    public class Formulario : IValidate
    {
        public override bool ValidateUser(string name, string password) 
        {
            var ret = false;
            if (name != null)
                if (password != null)
                    ret = true;
            Console.WriteLine("Validação feita em formulário:" + ret);
            // encadeia chamada
            if (_sucessor != null)
                _sucessor.ValidateUser(name, password);
            return ret;
        }
    }
}
