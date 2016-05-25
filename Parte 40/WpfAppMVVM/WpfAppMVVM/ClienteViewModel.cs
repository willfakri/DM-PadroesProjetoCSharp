using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppMVVM
{
    public class ClienteViewModel
    {
        private Cliente _cliente;

        public Cliente Cliente
        {
            get
            {
                return this._cliente;
            }
            set
            {
                this._cliente = value;
            }
        }

        public string Nome
        {
            // delegação
            get
            {
                return this.Cliente.Nome;
            }
            set
            {
                this.Cliente.Nome = value;
            }
        }
    }
}
