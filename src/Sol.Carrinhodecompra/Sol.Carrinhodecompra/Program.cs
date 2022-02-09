using System;
using Sol.Carrinhodecompra.Models;

namespace Sol.Carrinhodecompra
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public void CarrinhoDeCompras()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();

            carrinho.Adiciona(new Produto("Geladeira", 450.0M));
            carrinho.Adiciona(new Produto("Liquidificador", 250.0M));
            carrinho.Adiciona(new Produto("Jogo de pratos", 70.0M));

            MaiorEMenor algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);

            Console.WriteLine("O menor produto: " + algoritmo.Menor.Nome);
            Console.WriteLine("O Maior produto: " + algoritmo.Maior.Nome);

            Console.ReadKey();
        }

    }
}
