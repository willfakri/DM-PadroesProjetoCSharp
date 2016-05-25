using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateClassData
{
    class Program
    {
        static void Main(string[] args)
        {
            var cli = new Cliente(1, "Guinther", "123", "guintherpauli@gmail.com", "99999999");
            cli.MostrarCliente();
            cli.MostrarContatoCliente();
            Console.ReadLine();
        }
    }
}
