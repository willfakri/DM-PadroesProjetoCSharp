using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracaoTreino
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook() { Nome = "Dell" };
            notebook.Porta1 = new Impressora();
            notebook.Porta2 = new IPhone();
            notebook.Porta3 = new Mouse();

            notebook.Porta1.Plugar();
            notebook.Porta2.Plugar();
            notebook.Porta3.Plugar();

            notebook.Porta1.Desplugar();
            notebook.Porta2.Desplugar();
            notebook.Porta3.Desplugar();

            Console.ReadKey();
        }
    }
}
