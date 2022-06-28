using System;

namespace Heranças
{
    internal class Professor : Pessoa
    {
        
        public string NumeroFuncionario { get; set; }

        public decimal Salario { get; set; }

        public override string ObterNomeCompleto()
        {
            return $"{NumeroFuncionario} - e{Nome} {Sobrenome}";
        }

    }
}
