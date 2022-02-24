namespace Sol.Carrinhodecompra.CargoFuncionario
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }
        public Cargo Cargo { get; set; }

        public Funcionario(string nome, double salario, Cargo cargo)
        {
            Nome = nome;
            Salario = salario;
            Cargo = cargo;
        }
    }
}