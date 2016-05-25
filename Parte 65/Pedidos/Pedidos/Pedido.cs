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

        private IFabricaImposto _fabricaImposto;

        // agora dependência vem de fora e é passada como interface...
        public Pedido(IFabricaImposto fabricaImposto)
        {
            this._fabricaImposto = fabricaImposto;
        }

        public double CalcularValorTotal(Cliente cliente)
        {
            double total = _itensPedido.Sum((item) => {
                return item.Valor * item.Quantidade;
            });

            double taxas;
            // dependência concreta, fábrica de imposto
            // inverter a dependência ?
            IImposto imposto = _fabricaImposto.GetInstance();
            taxas = imposto.CalcularTaxas(cliente, total);
            total = total + taxas;
            return total;
        }        
    }
    // Factory

    public interface IFabricaImposto
    {
        IImposto GetInstance();
    }

    public class FabricaImposto : IFabricaImposto
    {
        public IImposto GetInstance()
        {
            return new ImpostoEstado();
        }
    }

    public class FabricaImpostoByCliente : IFabricaImposto
    {
        private Cliente _cliente;

        public FabricaImpostoByCliente(Cliente cliente)
        {
            this._cliente = cliente;
        }
        
        public IImposto GetInstance()
        {
            if(!string.IsNullOrEmpty(_cliente.Cidade))
                return new ImpostoCidade();
            else
                return new ImpostoEstado();
        }
    }

    public interface IImposto
    {
        double CalcularTaxas(Cliente cliente, double total);
    }

    public class ImpostoCidade : IImposto
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
            return taxas;
        }
    }

    public class ImpostoEstado : IImposto
    {
        public double CalcularTaxas(Cliente cliente, double total)
        {
            // taxas por estado
            double taxas = 0;
            if (cliente.Estado == "RS")
                taxas = total * 0.05;
            else
                if (cliente.Estado == "SC")
                    taxas = total * 0.10;
                else
                    taxas = total * 0.15;
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
