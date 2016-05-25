using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoD
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public Promocao Promocao { get; set; }
    }

    public class Promocao
    {
        public double Desconto { get; set; }
    }

    public class Reajuste
    {
        public List<Produto> Produtos { get; set; }
        public double TotalDesconto { get; set; }

        public void ReajustarPromocao()
        {
            TotalDesconto = 0;
            foreach(var produto in Produtos)
            {
                //produto.Promocao.Desconto = 2;
                TotalDesconto += (produto.Promocao.Desconto * produto.Valor / 100);
                produto.Valor = produto.Valor - (produto.Promocao.Desconto * produto.Valor / 100);                
            }
        }

        public Reajuste()
        {
            this.Produtos = new List<Produto>();
        }
    }

}
