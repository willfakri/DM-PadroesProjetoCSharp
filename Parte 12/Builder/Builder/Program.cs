using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            VeiculoBuilder builder;
            var director = new Director();

            // cria produto
            builder = new CarroBuilder();
            director.Construct(builder);
            builder.Veiculo.Mostrar();

            // cria produto
            builder = new MotoBuilder();
            director.Construct(builder);
            builder.Veiculo.Mostrar();

            Console.ReadLine();
        }
    }
}
