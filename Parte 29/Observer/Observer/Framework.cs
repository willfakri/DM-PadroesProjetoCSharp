using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    // Observer
    public abstract class Observer
    {
        public abstract void Update();
    }

    // Subject
    public abstract class Subject
    {
        private List<Observer> _observadores = new List<Observer>();

        public void Attach(Observer observer)
        {
            // adiciona um observador a lista
            _observadores.Add(observer);
        }

        public void Notify()
        {
            // broadcast
            foreach (var o in _observadores)
                o.Update();
        }
    }

    // Concrete Subject
    public class Balanco:Subject
    {
        // state = true se balanço está em andamento
        private bool _state = false;

        public bool State
        {
            get { return _state; }
            set { _state = value; }
        }

        public void Iniciar()
        {
            _state = true;
            Console.WriteLine("Balanço iniciado...");
            // notifica os observadores
            Notify();
        }

        public void Finalizar()
        {
            _state = false;
            Console.WriteLine("Balanço finalizado...");
            // notifica os observadores
            Notify();
        }
    }

    //Concrete Obbserver
    public class Venda:Observer
    {
        private bool _state = false;

        private Balanco _balanco;

        public Venda(Balanco balanco)
        {
            this._balanco = balanco;
        }

        public void Iniciar()
        {
            // state = true se  balanco foi iniciado
            if(!_state)
            Console.WriteLine("Venda iniciada...");
            else
                Console.WriteLine("Não posso iniciar venda pois balanço está em andamento");

        }

        public override void Update()
        {
            _state = _balanco.State;
        }
    }
}
