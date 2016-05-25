using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstracao
{
    public class Notebook
    {
        private string _nome;

        public USB Porta1
        {
            get
            {
                return null;                
            }
            set
            {
            }
        }

        public USB Porta2
        {
            get
            {
                return null;
            }
            set
            {
            }
        }

        public USB Porta3
        {
            get
            {
                return null;
            }
            set
            {
            }
        }
    
        public string getNome()
        {
            return _nome;
        }
        public Notebook(string nome)
        {
            _nome = nome;
        }
       
    }
    public abstract class USB
    {
        public abstract void Plugar();
    }

    public class iPhone : USB
    {
        public override void Plugar()
        {
        }
    }

    public class Mouse : USB
    {
        public override void Plugar()
        {
        }
    }

    public class Teclado : USB
    {
        public override void Plugar()
        {
        }
    }

    public class Tablet : USB
    {
        public override void Plugar()
        {
        }
    }
}
