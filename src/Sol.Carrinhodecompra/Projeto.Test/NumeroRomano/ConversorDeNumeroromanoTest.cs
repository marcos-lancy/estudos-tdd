using NUnit.Framework;
using Sol.Carrinhodecompra.NumeroRomano;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Test.NumeroRomano
{
    [TestFixture]
    public class ConversorDeNumeroromanoTest
    {
        [Test]
        public void DeveEntenderOSimcoloI()
        {
            ConversorDeNumeroromano romano = new ConversorDeNumeroromano();
            int numero = romano.Converte("I");

            Assert.AreEqual(1, numero);
        }

        [Test]
        public void DeveEntenderOSimboloV()
        {
            ConversorDeNumeroromano romano = new ConversorDeNumeroromano();
            int numero = romano.Converte("V");

            Assert.AreEqual(5, numero);
        }

        [Test]
        public void DeveEntenderDoisSimbolosComoII(){

            ConversorDeNumeroromano romano = new ConversorDeNumeroromano();
            int numero = romano.Converte("II");

            Assert.AreEqual(2, numero);
        }

        [Test]
        public void DeveEntenderQuatroSimbolosDoisADoisComoXXII(){

            ConversorDeNumeroromano romano = new ConversorDeNumeroromano();
            int numero = romano.Converte("XXII");

            Assert.AreEqual(22, numero);
        }

        [Test]
        public void DeveEntenderNumerosComoIX()
        {
            ConversorDeNumeroromano romano = new ConversorDeNumeroromano();
            int numero = romano.Converte("IX");

            Assert.AreEqual(9, numero);
        }

        public void DeveEntenderNumerosComplexosComoXXIV()
        {
            ConversorDeNumeroromano romano = new ConversorDeNumeroromano();
            int numero = romano.Converte("XXIV");

            Assert.Equals(24, numero);
        }

    }
}
 