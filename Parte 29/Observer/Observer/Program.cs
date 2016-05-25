using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    class Program
    {
        // Client
        static void Main(string[] args)
        {
            // Concrete Subject
            Balanco balanco = new Balanco();
            // Concrete Observer
            Venda venda = new Venda(balanco);
            // adicionar os observadores
            balanco.Attach(venda);
            //processo...
            balanco.Iniciar();
            //balanco.Finalizar();
            // pode vender?
            venda.Iniciar();
            Console.ReadLine();

        }
    }
}
