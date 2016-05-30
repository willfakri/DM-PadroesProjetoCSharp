using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegacaoTreino
{
    public class Gerente
    {
        private Estagiario _estagiario;
        private Tester _tester;
        private Developer _developer;
        private ArquitetoSoftware _arquiteto;

        public Gerente()
        {
            _estagiario = new Estagiario();
            _tester = new Tester();
            _developer = new Developer();
            _arquiteto = new ArquitetoSoftware();
            Console.WriteLine("Gerente juntou sua equipe para delegar as tarefas.");
        }

        public void Trabalhar(string tarefa)
        {
            _estagiario.Trabalhar(tarefa);
            _arquiteto.Trabalhar(tarefa);
            _developer.Trabalhar(tarefa);
            _tester.Trabalhar(tarefa);
        }
    }
}
