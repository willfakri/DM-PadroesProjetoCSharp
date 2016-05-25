﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente() { Codigo = 1, Nome = "Guither", Estado = "RS", Cidade = "SM" };
            var p = new Pedido(new FabricaImpostoByCliente(cliente));
            p._itensPedido.Add(new ItemPedido() { Codigo = "1", Valor = 100, Quantidade = 10 });
            p._itensPedido.Add(new ItemPedido() { Codigo = "2", Valor = 50, Quantidade = 5 });            
            var total = p.CalcularValorTotal(cliente);
            Console.WriteLine("Total do pedido: " + total);
            Console.ReadLine();
        }
    }
}
