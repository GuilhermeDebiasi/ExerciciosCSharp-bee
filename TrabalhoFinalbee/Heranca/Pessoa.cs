using System;

namespace Heranças
{
    public abstract class Pessoa
    { 
        public string Cpf { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public Pessoa()
        {
            System.Console.WriteLine("Construiu a Pessoa");
        }
            
        public virtual string ObterNomeCompleto()
        {
            return $"{Nome} {Sobrenome}";
        }

    }
}
