using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesTreino
{
    class Program
    {
        static void Main(string[] args)
        {
            Arquivo mp3 = new MP3() { Nome = "Pearl Jam" };
            mp3.Abrir();

            Jpeg jpeg = new Jpeg() { Nome = "Foto do parque" };
            jpeg.Abrir();
            jpeg.Imprimir();

            Documento documento = new Documento() { Nome = "Curriculo" };
            documento.Abrir();
            documento.Imprimir();

            Console.ReadKey();
        }
    }
}
