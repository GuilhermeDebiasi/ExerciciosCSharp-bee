using System;

namespace Heranças
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int tipo;

            Console.WriteLine("Tipos de Pessoa:");
            Console.WriteLine();
            Console.WriteLine("(1) Aluno");
            Console.WriteLine("(2) Professor");
            Console.WriteLine("(3) Diretor");
            Console.WriteLine();
            Console.WriteLine("Informe o Tipo:");
            
            int.TryParse(Console.ReadLine(), out tipo);

            Pessoa pessoa = CriarPessoa(tipo);
            Ipessoa pessoaDois = CriarInterfacePessoa(tipo);

            pessoaDois.ObterNomeComProfissao();
            
            ExibirNomeCompleto (pessoa);

            Console.ReadKey();
        }

        public static void ExibirNomeCompleto(Pessoa pessoa)
        {
            Console.WriteLine(pessoa.ObterNomeCompleto());
        }

        public static Pessoa CriarPessoa(int tipo)
        {
            if (tipo == 1)
                return CriarAluno();

            if (tipo == 2)
                return CriarProfessor();

            if (tipo == 3) 
            return CriarDiretor();

            return null;
        }

        public static Aluno CriarAluno()
        {
            return new Aluno()
            {
                Cpf = "111.111.111-11",
                Nome = "João",
                Sobrenome = "Silva",
                MediaNotas = 9m,
                NumeroMatricula = "00123",
            };
        }

        public static Professor CriarProfessor()
        {
            return new Professor("1234")
            {
                Cpf = "222.222.222-22",
                Nome = "Maria",
                Sobrenome = "Rocha",
                Salario = 1000.50m,
                Curso = "Programação"
            };
        }

        public static Diretor CriarDiretor()
        {
            return new Diretor("5678")
            {
                Cpf = "555.555.555-55",
                Nome = "Mateus",
                Sobrenome = "Vieira",
                Salario = 2000.78m,
                Area = "Exatas"
            };
        }
    }
}
