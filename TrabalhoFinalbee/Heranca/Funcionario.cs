using System;   

namespace Heranças
{
    internal class Funcionario : Pessoa
    {
        public string NumeroFuncionario { get; private set; }

        public decimal Salario { get; set; }

        public Funcionario()
        {
            
            System.Console.WriteLine("Construiu o Funcionario");
        }

        public Funcionario(string numeroFuncionario)
        {
            NumeroFuncionario = numeroFuncionario;
            System.Console.WriteLine("Construiu o Funcionario com Parâmetro");
        }

        public override string ObterNomeCompleto()
        {
            return $"{NumeroFuncionario} - {base.ObterNomeCompleto()}";
        }
    }
}
