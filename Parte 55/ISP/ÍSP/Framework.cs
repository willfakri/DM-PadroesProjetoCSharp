using System;
using System.Collections.Generic;

namespace ISP
{
    public interface IImprimir
    {
        void Imprimir();
    }

    public interface IEditar
    {
        void Editar();
    }

    public interface IReproduzir
    {
        void Reproduzir();
    }

    public interface IVisualizar
    {
        void Visualizar();
    }

    public interface IArquivo
    {
        void Abrir();
        void Fechar();
    }

    public class Arquivo : IArquivo
    {
        public string Nome { get; set; }
        public int Tamanho { get; set; }
    
        public void Abrir()
        {
 	        //
        }

        public void Fechar()
        {
 	        //
        }
    }

    public class Musica : Arquivo, IReproduzir
    {
        public string Artista { get; set; }

    
        public void Reproduzir()
        {
 	        throw new NotImplementedException();
        }
    }

    public class Documento : Arquivo, IVisualizar, IImprimir
    {
        public string Titulo { get; set; }
    
        public void Visualizar()
        {
 	        //
        }
    
        public void Imprimir()
        {
 	        //
        }
    }

    public class Foto : Arquivo, IVisualizar, IImprimir
    {
        public string Resolucao { get; set; }
    
        public void Visualizar()
        {
 	        Console.WriteLine("Visualizando foto "+Nome);
        }
    
        public void Imprimir()
        {
 	        //
        }
    }
}
