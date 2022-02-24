using System;
using Sol.Carrinhodecompra.CargoFuncionario.Interfaces;

namespace Sol.Carrinhodecompra.CargoFuncionario
{
    public class CalculadoraDeSalario
    {
        public double CalculaSalario(Funcionario funcionario)
        {
            return funcionario.Cargo.Regra.Calcula(funcionario);
        }
    }
}