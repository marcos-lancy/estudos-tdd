using NUnit.Framework;
using Sol.Carrinhodecompra.CarrinhoDeCompra2;

namespace Projeto.Test.CarrinhoDeCompra2
{
    [TestFixture]
    public class TestMaiorMenorValor
    {
        private CarrinhoDeCompras carrinho;

        [SetUp]
        public void Inicializar(){
            this.carrinho = new CarrinhoDeCompras();
        }

<<<<<<< HEAD
=======

>>>>>>> 16ef3d34f008de7a2fc743f2df7a8b9a86c9f470
        [Test]
        public void DeveRetornarZeroSeCarrinhoVazio(){
            double valor = carrinho.Encontra(carrinho);

            Assert.AreEqual(0.0, valor, 0.0001);
            
        }

        [Test]
        public void DeveRetornarValorDoItemSeCarrinhoCom1Elemento(){
            carrinho.Adiciona(new Item("Computador", 1 , 900.0));

            double valor = carrinho.Encontra(carrinho);

            Assert.AreEqual(900.0, valor, 0.0001);
        }

        // Item mais caro primeior
        [Test] public void DeveRetornarMaiorValorSeCarrinhoContemMuitosElementos1() 
<<<<<<< HEAD
        { 
=======
        {  
>>>>>>> 16ef3d34f008de7a2fc743f2df7a8b9a86c9f470
            carrinho.Adiciona(new Item("Fogão", 1, 1500.0)); 
            carrinho.Adiciona(new Item("Geladeira", 1, 900.0)); 
            carrinho.Adiciona(new Item("Máquina de Lavar", 1, 750.0)); 
            
            double valor = carrinho.Encontra(carrinho); 
            
            Assert.AreEqual(1500.0, valor, 0.0001); 
        }

        // Item mais caro por segundo
        [Test] public void DeveRetornarMaiorValorSeCarrinhoContemMuitosElementos2() 
<<<<<<< HEAD
        { 
=======
        {  
>>>>>>> 16ef3d34f008de7a2fc743f2df7a8b9a86c9f470
            carrinho.Adiciona(new Item("Geladeira", 1, 900.0)); 
            carrinho.Adiciona(new Item("Fogão", 1, 1500.0)); 
            carrinho.Adiciona(new Item("Máquina de Lavar", 1, 750.0)); 

            double valor = carrinho.Encontra(carrinho); 
            
            Assert.AreEqual(1500.0, valor, 0.0001); 
        }

        // Item mais caro por ultimo
        [Test] public void DeveRetornarMaiorValorSeCarrinhoContemMuitosElementos3() 
<<<<<<< HEAD
        { 
=======
        {  
>>>>>>> 16ef3d34f008de7a2fc743f2df7a8b9a86c9f470
            carrinho.Adiciona(new Item("Geladeira", 1, 900.0)); 
            carrinho.Adiciona(new Item("Máquina de Lavar", 1, 750.0)); 
            carrinho.Adiciona(new Item("Fogão", 1, 1500.0)); 

            double valor = carrinho.Encontra(carrinho); 
            
            Assert.AreEqual(1500.0, valor, 0.0001); 
        }
    }
}