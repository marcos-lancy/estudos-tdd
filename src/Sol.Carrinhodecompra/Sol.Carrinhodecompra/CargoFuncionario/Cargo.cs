

using Sol.Carrinhodecompra.CargoFuncionario.Interfaces;

namespace Sol.Carrinhodecompra.CargoFuncionario
{
    public class Cargo{

        public Cargo DESENVOLVEDOR{
            get {
                return new Cargo(new DezOuVintePorCento());
            }
        }

        public Cargo DBA{
            get{
                return new Cargo(new QuinzeOuVinteCincoPorCento());
            }
        }

        public Cargo TESTADOR{
            get{
                return new Cargo(new QuinzeOuVinteCincoPorCento());
            }
        }

        public IRegraDeCalculo Regra {
            get; private set;
        }

        private Cargo(IRegraDeCalculo regra){
            this.Regra = regra;
        }

        
    }

    public class DezOuVintePorCento : IRegraDeCalculo
    {
        public double Calcula(Funcionario f)
        {
            if(f.Salario > 3000){
                return f.Salario * 0.8;
            }

            return f.Salario * 0.9;
        }
    }

    public class QuinzeOuVinteCincoPorCento : IRegraDeCalculo
    {
        public double Calcula(Funcionario f)
        {
            if(f.Salario < 2500){
                return f.Salario * 0.85;
            }

            return f.Salario * 0.75;
        }
    }
}