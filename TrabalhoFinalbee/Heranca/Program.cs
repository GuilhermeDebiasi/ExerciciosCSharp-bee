using System;

namespace Heranças
{
    internal class Program
    {
        static void Main(string[] args)
        {                         
            Aluno aluno = CriarAluno();
            Professor professor = CriarProfessor();

            ExibirNomeCompleto(aluno);
            ExibirNomeCompleto(professor);
            
            Console.ReadKey();
        }

        public static void ExibirNomeCompleto(Pessoa pessoa)
        {
            Console.WriteLine(pessoa.ObterNomeCompleto());
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
            return new Professor()
            {
                Cpf = "222.222.222-22",
                Nome = "Maria",
                Sobrenome = "Rocha",
                NumeroFuncionario = "1324",
               Salario = 1000.50m
            };
        }
    }
}
