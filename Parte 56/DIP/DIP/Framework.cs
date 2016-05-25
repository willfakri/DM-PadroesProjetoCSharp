using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class Pedido
    {
        // encapsulamento
        private Boleto _boleto;

        public void Pagar(double valor)
        {
            // delegação
            this._boleto.Pagar(valor);
        }

        public Pedido()
        {
            this._boleto = new Boleto();
        }
    }

    public class Boleto
    {
        public void Pagar(double valor)
        {
            // simulando pagamento via boleto
            Console.WriteLine("Pago boleto no valor de " + valor);
        }
    }

    public class CartaoCredito
    {
        public void Pagar(double valor)
        {
            // simulando pagamento via cartão
            Console.WriteLine("Debitado valor no cartão " + valor);
        }
    }
}
