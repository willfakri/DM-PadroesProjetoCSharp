using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    // Produto Concreto
    public class AutenticacaoGoogle:Autenticacao
    {
        public override void Autenticar()
        {
            Console.WriteLine("Autenticado via Google");
        }
    }
}
