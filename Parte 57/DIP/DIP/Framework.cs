﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public interface IFormaPagamento
    {
        void Pagar(double valor);
    }

    // OCP
    public class Pedido
    {
        // encapsulamento
        // programar para interfaces / abstrações
        private IFormaPagamento _forma;

        public void Pagar(double valor)
        {
            // delegação
            this._forma.Pagar(valor);
        }

        public Pedido(IFormaPagamento forma)
        {
            this._forma = forma;
        }
    }

    public class Boleto : IFormaPagamento
    {
        public void Pagar(double valor)
        {
            // simulando pagamento via boleto
            Console.WriteLine("Pago boleto no valor de " + valor);
        }
    }

    public class CartaoCredito : IFormaPagamento
    {
        public void Pagar(double valor)
        {
            // simulando pagamento via cartão
            Console.WriteLine("Debitado valor no cartão " + valor);
        }
    }

    public class Cheque : IFormaPagamento
    {
        public void Pagar(double valor)
        {
            // simulando pagamento via cartão
            Console.WriteLine("Cheque assinado no valor de " + valor);
        }
    }
}
