using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            // cria originator
            Pessoa gp = new Pessoa();
            gp.State = "Guinther";
            // mostra estado original
            Console.WriteLine("Estado original: " + gp.State);
            Caretaker c = new Caretaker();
            c.Memento = gp.CreateMemento();
            // trocando o estado...
            gp.State = "Pauli";
            // mostra estado atual
            Console.WriteLine("Estado atual: " + gp.State);
            //restaurar oe stado original
            gp.setMemento(c.Memento);
            // mostra estado atual
            Console.WriteLine("Estado restaurado: " + gp.State);
            Console.ReadLine();
        }
    }

    // Originator
    public class Pessoa
    {
        private string _state;
        public string State
        {
            get { return _state; }
            set
            {
                _state = value;
            }
        }
        public Memento CreateMemento()
        {
            return new Memento(_state);
        }

        public void setMemento(Memento memento)
        {
            Console.WriteLine("Restaurando o estado...");
            State = memento.State;
        }
    }

    // Memento
    public class Memento
    {
        private string _state;
        public Memento(string state)
        {
            _state = state;
        }
        public string State
        {
            get { return _state; }
        }
    }

    // Caretaker
    public class Caretaker
    {
        private Memento _memento;

        public Memento Memento
        {
            set { _memento = value; }
            get { return _memento; }          
        }
    }
}
