using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    public interface IEditar
    {
        void Editar();
    }

    public interface IImprimir
    {
        void Imprimir();
    }

    public abstract class Arquivo
    {
        private int _tamArquivo;

        public int TamArquivo
        {
            get { return _tamArquivo; }
            set { _tamArquivo = value; }
        }
        protected string _descricao;

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }
                        
        public virtual void Abrir()
        {
            Console.WriteLine("Abrindo arquivo " + _descricao + "...");
        }
    }

    public class MP3: Arquivo
    {
        public override void Abrir()
        {
            base.Abrir();
            Console.WriteLine("Tocando arquivo MP3 " + _descricao + "...");
        }
    }
    public class Foto: Arquivo, IImprimir, IEditar
    {
        public override void Abrir()
        {
            base.Abrir();
            Console.WriteLine("Mostrando imagem " + _descricao + "...");
        }

        public void Imprimir()
        {
            //
        }

        public void Editar()
        {
            //
        }
    }
    public class Documento: Arquivo, IEditar, IImprimir
    {
        public override void Abrir()
        {
            base.Abrir();
            Console.WriteLine("Exibindo documento " + _descricao + "...");
        }

        public void Editar()
        {
            throw new NotImplementedException();
        }

        public void Imprimir()
        {
            throw new NotImplementedException();
        }
    }
}
