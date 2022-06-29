using System;

namespace Heranças  
{
    internal class Professor : Funcionario
    {
        
        public string Curso { get; set; }

        

        public override string ObterNomeCompleto()
        {
            return $"{base.ObterNomeCompleto()}";
        }
        public Professor(string numeroFuncionario) : base(numeroFuncionario)
        {
            System.Console.WriteLine("Construiu o Professor");
        }
    }
}
