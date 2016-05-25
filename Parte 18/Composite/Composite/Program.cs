using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var form = new Formulario("Cadastro Clientes");
            form.Add(new Button("Incluir"));
            form.Add(new Button("Consultar"));
            form.Add(new TextBox("Nome"));
            form.Add(new TextBox("Fone"));
            form.Display();
            Console.ReadLine();
        }
    }
}
