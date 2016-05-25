using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Encapsulamento
{
    class Program
    {
        //Usuário (Client)
        static void Main(string[] args)
        {
            Carro Astra = new Carro("GM Astra GSI");
            Console.WriteLine(Astra.Nome + " foi criado");    
            Astra.Ligar();
            Astra.Mover();
            Astra.Abastecer();
            Astra.Mover();
        }
    }
}
