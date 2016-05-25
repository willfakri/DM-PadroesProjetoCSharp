using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Arquivo doc = new Documento() { Descricao = "Artigo .net Magazine" };
            MP3 musica = new MP3() { Descricao = "Dream Theater" };
            Foto foto = new Foto() { Descricao = "Palestra Delphi Conference" };
            doc.Abrir();
            musica.Abrir();
            foto.Abrir();
            foto.Imprimir();
            Console.ReadLine();
        }
    }
}
