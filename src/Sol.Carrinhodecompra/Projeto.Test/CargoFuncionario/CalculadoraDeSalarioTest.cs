using NUnit.Framework;
using Sol.Carrinhodecompra.CargoFuncionario;

namespace Projeto.Test.CargoFuncionario
{
    [TestFixture]
    public class CalculadoraDeSalarioTest
    {
        private CalculadoraDeSalario calculadora;

        [SetUp]
        public void Inicializar(){
            this.calculadora = new CalculadoraDeSalario();
        }

        [Test]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAbaixoDoLimite(){
            
            Funcionario desenvolvedor = new Funcionario("Marcos", 1500.0, Cargo.DESENVOLVEDOR);

            double salario = calculadora.CalculaSalario(desenvolvedor);

            Assert.AreEqual(1500.0 * 0.9, salario, 0.00001);
        }

        [Test]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAcimaDoLimite(){
            
            Funcionario desenvolvedor = new Funcionario("mauricio", 4000.0, Cargo.DESENVOLVEDOR);

            double salario = calculadora.CalculaSalario(desenvolvedor);

            Assert.AreEqual(4000.0 * 0.8, salario, 0.00001);
        }

        [Test]
        public void deveCalcularSalarioParaDBAsComSalarioAbaixoDoLimite(){
            
            Funcionario desenvolvedor = new Funcionario("mauricio", 1500.0, Cargo.DBA);

            double salario = calculadora.CalculaSalario(desenvolvedor);

            Assert.AreEqual(1500.0 * 0.85, salario, 0.00001);
        }
    }
}