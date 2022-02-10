using NUnit.Framework;
using Sol.Carrinhodecompra.CarrinhoDeCompra2;

namespace Projeto.Test.CarrinhoDeCompra2
{
    [TestFixture]
    public class TestMaiorMenorValor
    {
        [Test]
        public void DeveRetornarZeroSeCarrinhoVazio(){
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            double valor = carrinho.Encontra(carrinho);

            Assert.AreEqual(0.0, valor, 0.0001);
            
        }

        [Test]
        public void DeveRetornarValorDoItemSeCarrinhoCom1Elemento(){
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            carrinho.Adiciona(new Item("Computador", 1 , 900.0));

            double valor = carrinho.Encontra(carrinho);

            Assert.AreEqual(900.0, valor, 0.0001);
        }

        // Item mais caro primeior
        [Test] public void DeveRetornarMaiorValorSeCarrinhoContemMuitosElementos1() 
        { 
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras(); 
            carrinho.Adiciona(new Item("Fogão", 1, 1500.0)); 
            carrinho.Adiciona(new Item("Geladeira", 1, 900.0)); 
            carrinho.Adiciona(new Item("Máquina de Lavar", 1, 750.0)); 
            
            double valor = carrinho.Encontra(carrinho); 
            
            Assert.AreEqual(1500.0, valor, 0.0001); 
        }

        // Item mais caro por segundo
        [Test] public void DeveRetornarMaiorValorSeCarrinhoContemMuitosElementos2() 
        { 
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras(); 
            carrinho.Adiciona(new Item("Geladeira", 1, 900.0)); 
            carrinho.Adiciona(new Item("Fogão", 1, 1500.0)); 
            carrinho.Adiciona(new Item("Máquina de Lavar", 1, 750.0)); 

            double valor = carrinho.Encontra(carrinho); 
            
            Assert.AreEqual(1500.0, valor, 0.0001); 
        }

        // Item mais caro por ultimo
        [Test] public void DeveRetornarMaiorValorSeCarrinhoContemMuitosElementos3() 
        { 
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras(); 
            carrinho.Adiciona(new Item("Geladeira", 1, 900.0)); 
            carrinho.Adiciona(new Item("Máquina de Lavar", 1, 750.0)); 
            carrinho.Adiciona(new Item("Fogão", 1, 1500.0)); 

            double valor = carrinho.Encontra(carrinho); 
            
            Assert.AreEqual(1500.0, valor, 0.0001); 
        }
    

    }
}