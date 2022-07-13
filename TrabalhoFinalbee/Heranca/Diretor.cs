using System;

namespace Heranças
{
    internal class Diretor : Funcionario
    {
        public string Area { get; set; }

        public Diretor(string numeroFuncionario) : base(numeroFuncionario)
        {
           
            System.Console.WriteLine("Construiu o Diretor");
        }
        public override string ObterProfissao()
        {
            return "Diretor";
        }
        public string ObterNomeComProfissao()
        {
            return $"{nome}";
        }
    }

}
