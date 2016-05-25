using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    // Abstract Class
    public abstract class Correcao
    {
        public abstract void Corrigir();
        public abstract void VerificarPrerequisitos();
        public abstract void EnviarDadosParaBancoDeDados();
        public abstract void LimparCorrecoesAnteriores();
        public abstract void Iniciar();

        // Template Method
        public void Processar()
        {
            Iniciar();
            VerificarPrerequisitos();
            LimparCorrecoesAnteriores();
            Corrigir();
            EnviarDadosParaBancoDeDados();
        }
    }

    // Concrete Class
    public class CorrecaoProva : Correcao
    {
        public override void Iniciar()
        {
            Console.WriteLine("Iniciando correção de Prova...");
        }

        public override void Corrigir()
        {
            Console.WriteLine("Corrigindo prova...");
        }

        public override void VerificarPrerequisitos()
        {
            Console.WriteLine("Verificando pré-requisitos...");
        }

        public override void EnviarDadosParaBancoDeDados()
        {
            Console.WriteLine("Enviando dados para o BD...");
        }

        public override void LimparCorrecoesAnteriores()
        {
            Console.WriteLine("Limpando dados anteriores do BD...");
        }
    }

    // Concrete Class
    public class CorrecaoRedacao : Correcao
    {
        public override void Iniciar()
        {
            Console.WriteLine("Iniciando correção de Redação...");
        }

        public override void Corrigir()
        {
            Console.WriteLine("Corrigindo redação...");
        }

        public override void VerificarPrerequisitos()
        {
            Console.WriteLine("Verificando pré-requisitos...");
        }

        public override void EnviarDadosParaBancoDeDados()
        {
            Console.WriteLine("Enviando dados para o BD...");
        }

        public override void LimparCorrecoesAnteriores()
        {
            Console.WriteLine("Limpando dados anteriores do BD...");
        }
    }
}
