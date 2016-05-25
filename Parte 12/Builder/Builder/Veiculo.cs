using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    //Produto
    public class Veiculo
    {
        private string _tipo;
        private Dictionary<string, string> _parts = new Dictionary<string, string>();

        //construtor
        public Veiculo(string tipo)
        {
            this._tipo = tipo;
        }

        // indexer
        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void Mostrar()
        {
            Console.WriteLine("\n-----------------------------------------");
            Console.WriteLine("Tipo: {0}", _tipo);
            Console.WriteLine("Motor: {0}", _parts["motor"]);
            Console.WriteLine("Pneus {0}", _parts["pneus"]);
            Console.WriteLine("Portas: {0}", _parts["portas"]);
        }
    }
}
