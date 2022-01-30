using NUnit.Framework;
using Sol.Carrinhodecompra.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Test.CarrinhoDeCompra
{
    [TestFixture]
    public class TestaMaiorMenor
    {
        [Test]
        public void OrdemDecrescente()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();

            carrinho.Adiciona(new Produto("Geladeira", 450.0M));
            carrinho.Adiciona(new Produto("Liquidificador", 250.0M)); 
            carrinho.Adiciona(new Produto("Jogo de pratos", 70.0M));

            MaiorEMenor algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);

            Assert.AreEqual("Jogo de pratos", algoritmo.Menor.Nome);
            Assert.AreEqual("Geladeira", algoritmo.Maior.Nome);
        }

        [Test]
        public void ApenasUmProduto()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();

            carrinho.Adiciona(new Produto("Geladeira", 450.0M));

            MaiorEMenor algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);

            Assert.AreEqual("Geladeira", algoritmo.Menor.Nome);
            Assert.AreEqual("Geladeira", algoritmo.Maior.Nome);
        }
    }
}
