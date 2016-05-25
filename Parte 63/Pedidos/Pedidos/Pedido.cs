using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos
{
    public class Pedido
    {
        public List<ItemPedido> _itensPedido = new List<ItemPedido>();

        // Violando SRP (SOLID)
        // Violando OCP (SOLID)
        public double CalcularValorTotal(Cliente cliente)
        {
            double total = _itensPedido.Sum((item) => {
                return item.Valor * item.Quantidade;
            });

            double taxas;

            if (cliente.Estado == "RS")
                taxas = total * 0.05;
            else
                if (cliente.Estado == "SC")
                    taxas = total * 0.10;
                else
                    taxas = total * 0.15;
                // outro estado?
            total = total + taxas;
            return total;
        }
    }

    public class ItemPedido
    {
        public string Codigo;
        public int Quantidade;
        public double Valor;
    }

    public class Cliente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }
    }
}
