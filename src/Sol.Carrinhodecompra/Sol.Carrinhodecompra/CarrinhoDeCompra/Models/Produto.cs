using System;

namespace Sol.Carrinhodecompra.Models
{
    public class Produto
    {
        public Produto(string nome, decimal valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public string Nome { get; set; }
        public decimal Valor { get; set; }
    }
}
