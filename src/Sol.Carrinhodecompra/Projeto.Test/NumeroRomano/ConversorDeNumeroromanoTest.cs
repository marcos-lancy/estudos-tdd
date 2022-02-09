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
    }
}
