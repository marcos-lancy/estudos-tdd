using System.Collections.Generic;

namespace Sol.Carrinhodecompra.CarrinhoDeCompra2
{
    public class CarrinhoDeCompras
    {
        public IList<Item> Itens { get; private set; }   

        public CarrinhoDeCompras()
        {
            this.Itens = new List<Item>();
        }

        public void Adiciona(Item item){
            this.Itens.Add(item);
        }

        public double Encontra(CarrinhoDeCompras carrinho){

            if(carrinho.Itens.Count == 0 ) return 0;

            double maior = carrinho.Itens[0].ValorTotal;

            foreach (var item in carrinho.Itens)
            {
                if(maior < item.ValorTotal)
                    maior = item.ValorTotal;
            }

            return maior;
        }
    }

    public class Item{
        public string Descricao { get; private set; }
        public int Quantidade { get; private set; }
        public double ValorUnitario { get; private set; }

        public Item(string descricao, int quantidade, double valorUnitario)
        {
            this.Descricao = descricao;
            this.Quantidade = quantidade;
            this.ValorUnitario = valorUnitario;
        }

        public double ValorTotal{
            get
            {
                return this.ValorUnitario * this.Quantidade;
            }
        }
    }

    // public class carrinhoDeComprasBuilder
    // {
    //     public CarrinhoDeCompras Criar(){}

    //     public carrinhoDeComprasBuilder ComItens(double valores)
    //     {
    //         foreach (var valor in valores)
    //         {
    //             carrinho.Adicionar()
    //         }
    //     }
    // }
}