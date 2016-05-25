using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoD
{
    class Program
    {
        static void Main(string[] args)
        {
            var promocao = new Promocao() { Desconto = 20 };
            var p1 = new Produto() { Codigo = 1, Nome = "iPad", Valor = 2000, Promocao = promocao };
            var p2 = new Produto() { Codigo = 2, Nome = "iPhone", Valor = 1500, Promocao = promocao };
            var reajuste = new Reajuste();
            reajuste.Produtos.Add(p1);
            reajuste.Produtos.Add(p2);
            reajuste.ReajustarPromocao();
            Console.WriteLine("Produto:{0}, Valor:{1}", p1.Nome, p1.Valor);
            Console.WriteLine("Produto:{0}, Valor:{1}", p2.Nome, p2.Valor);
            Console.WriteLine("Total desconto: {0}", reajuste.TotalDesconto);
            Console.ReadLine();
        }
    }
}
