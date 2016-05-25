using System;
namespace Bridge
{
    // Abstraction
    public abstract class Exportacao
    {
        protected ExportacaoImpl _implementor;

        public ExportacaoImpl Implementor
        {
            set { _implementor = value; }
        }

        public virtual void Exportar()
        {
            // implementação por delegação
            _implementor.Exportar();
        }
    }
}
