using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoTreino
{
    public class Barco
    {
        public string Modelo { get; set; }

        public void Mover()
        {
            Console.WriteLine(Modelo + " está navegando.");
        }
    }
}
