using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    // Singleton
    public class ConexaoBD
    {
        // guarda internamente a instância
        private static ConexaoBD _instance;
        // esconde o construtor
        protected ConexaoBD()
        {
        }
        // método que retorna singleton
        public static ConexaoBD Instance()
        {
            //  garante que semper uma instância existe, só uma
            if (_instance == null)
                _instance = new ConexaoBD();
            return _instance;
        }

        public string stringConexao { get; set; }
        public void Open()
        {
            Console.WriteLine("Abrindo conexao com banco "+stringConexao);
        }

    }
}
