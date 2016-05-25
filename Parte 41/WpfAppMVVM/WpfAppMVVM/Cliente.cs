using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Model
namespace WpfAppMVVM
{
    public class Cliente
    {
        private int _id;
        private string _nome;
        private string _fone;

        public int ID
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }

        public string Nome
        {
            get
            {
                return this._nome;
            }
            set
            {
                this._nome = value;
            }
        }

        public string Fone
        {
            get
            {
                return this._fone;
            }
            set
            {
                this._fone = value;
            }
        }
    }
}
