using System.Collections.Generic;

namespace Sol.Carrinhodecompra.Models
{
    public class CarrinhoDeCompras
    {
        public List<Produto> Produtos { get; set; }

        public CarrinhoDeCompras()
        {
            Produtos = new List<Produto>();
        }

        public void Adiciona(Produto produto)
        {
            Produtos.Add(produto);
        }
    }
}
