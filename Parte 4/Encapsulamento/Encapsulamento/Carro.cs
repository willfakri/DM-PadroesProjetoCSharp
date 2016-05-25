using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Encapsulamento
{
    public class Bateria
    {
    }

    public class SuperBateria : Bateria
    {
    }

    public class Motor
    {
    }

    public class Carro
    {
        //Encapsulando detalhes do carro
        //composicao
        private Motor _motor;
        private Bateria _bateria;
        private string _nome;
        private void Ignicao()
        {
            Console.WriteLine("Foi dada ignição no carro...");    
        }

        //Propriedade...
        public string Nome
        {
            get
            {
                return _nome;
            }
        }

        //Construtor
        public Carro(string nome)
        {
            Console.WriteLine("Criando objeto carro...");
            _motor = new Motor();
            _bateria = new Bateria();
            _nome = nome;
        }
        public int NumPneus()
        {
            return 4;
        }
        public void Abastecer()
        {
            Console.WriteLine("Abastecendo carro...");
        }
        public void Ligar()
        {
            Console.WriteLine("Ligando carro...");
            Ignicao();
        }
        public void Mover()
        {
            Console.WriteLine("Movendo   carro...");
        }
    }
}
