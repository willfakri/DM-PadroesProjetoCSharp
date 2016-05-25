using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroMvvm;
using System.Windows.Input;

namespace WpfAppMVVM
{
    // ViewModel
    public class ClienteViewModel : ObservableObject
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

        #region Properties
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

        public int ID
        {
            get
            {
                return this.Cliente.ID;
            }
            set
            {
                if (Cliente.ID != value) // realmente trocou para um valor diferente
                {
                    this.Cliente.ID = value;
                    RaisePropertyChanged("ID");
                }
            }
        }

        public string Fone
        {
            get
            {
                return this.Cliente.Fone;
            }
            set
            {
                if (Cliente.Fone != value)
                {
                    this.Cliente.Fone = value;
                    RaisePropertyChanged("Fone");
                }
            }
        }
        #endregion

        #region Commands
        void UpdateNomeClienteExecute()
        {
            ID = 123;
            Nome = "Guinther";
            Fone = "9999-9999";
        }
        bool CanUpdateNomeCliente()
        {
            return true;
        }
        public ICommand UpdateNomeCliente
        {
            get
            {
                return new RelayCommand(UpdateNomeClienteExecute, CanUpdateNomeCliente);
            }
        }
        #endregion
    }
}
