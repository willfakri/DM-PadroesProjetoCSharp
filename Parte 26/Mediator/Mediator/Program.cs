using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator mediator = new ConcreteMediator();
            Suporte suporte = new Suporte(mediator);
            Usuario usuario = new Usuario(mediator);
            mediator.Suporte = suporte;
            mediator.Usuario = usuario;
            usuario.Send("Meu Windows não está entrando!!!");
            suporte.Send("Formate a máquina...");
            Console.ReadLine();
        }
    }

    // Mediator
    public abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);
    }

    //Concrete Mediator
    public class ConcreteMediator : Mediator
    {
        private Suporte _suporte;
        private Usuario _usuario;

        public Suporte Suporte
        {
            set { _suporte = value; }
        }

        public Usuario Usuario
        {
            set { _usuario = value; }
        }

        public override void Send(string message, Colleague colleague)
        {
            if (colleague == _usuario)
                _suporte.Notify(message);
            else
                _usuario.Notify(message);

        }
    }

    // Colleague (abstract)
    public abstract class Colleague
    {
        protected Mediator _mediator;
        // Construtor
        public Colleague(Mediator mediator)
        {
            this._mediator = mediator;
        }
    }

    // Concrete Colleague
    public class Suporte : Colleague
    {
        public Suporte(Mediator mediator)
            :base(mediator)
        {
        }
        public void Send(string mensagem)
        {
            _mediator.Send(mensagem, this);
        }
        public void Notify(string message)
        {
            Console.WriteLine("Suporte recebeu a mensagem: " + message);
        }
    }

    // Concrete Colleague
    public class Usuario : Colleague
    {
        public Usuario(Mediator mediator)
            : base(mediator)
        {
        }
        public void Send(string message)
        {
            _mediator.Send(message, this);
        }
        public void Notify(string message)
        {
            Console.WriteLine("Usuário recebeu a mensagem: " + message);
        }
    }
}
