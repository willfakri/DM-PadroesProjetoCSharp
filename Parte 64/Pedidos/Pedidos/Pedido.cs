using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos
{
    // OCP, SRP
    public class Pedido
    {
        public List<ItemPedido> _itensPedido = new List<ItemPedido>();

        public double CalcularValorTotal(Cliente cliente)
        {
            double total = _itensPedido.Sum((item) => {
                return item.Valor * item.Quantidade;
            });

            double taxas;
            // Programando para Interfaces
            IImposto imposto = new FabricaImposto().GetInstance();
            taxas = imposto.CalcularTaxas(cliente, total);
            total = total + taxas;
            return total;
        }        
    }

    public class FabricaImposto
    {
        public IImposto GetInstance()
        {
            return new Imposto();
        }
    }

    public interface IImposto
    {
        double CalcularTaxas(Cliente cliente, double total);
    }

    public class Imposto : IImposto
    {
        public double CalcularTaxas(Cliente cliente, double total)
        {
            double taxas = 0;
            //taxa por cidade
            if (!string.IsNullOrEmpty(cliente.Cidade))
            {
                if (cliente.Cidade == "SM")
                    taxas = total * 0.03;
                else
                    if (cliente.Cidade == "POA")
                        taxas = total * 0.04;
            }
            else //taxa por estado
                if (cliente.Estado == "RS")
                    taxas = total * 0.05;
                else
                    if (cliente.Estado == "SC")
                        taxas = total * 0.10;
                    else
                        taxas = total * 0.15;
            total = total + taxas;
            return taxas;
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
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}
