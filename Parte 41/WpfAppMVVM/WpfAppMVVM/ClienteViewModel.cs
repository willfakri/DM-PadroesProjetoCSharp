using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppMVVM
{
    // ViewModel
    public class ClienteViewModel : INotifyPropertyChanged
    {
        public ClienteViewModel()
        {
            this._cliente = new Cliente()
            {
                ID = 0,
                Nome = "",
                Fone = ""
            };
        }

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
                if (Cliente.Nome != value)
                {
                    this.Cliente.Nome = value;
                    RaisePropertyChanged("Nome");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
