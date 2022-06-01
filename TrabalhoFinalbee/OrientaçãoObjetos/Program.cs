using System;

namespace classe
{
    internal class Program
    {

        static void Main(string[] args)
        {


            // Aqui cria as pessoas sem utilizar as classes
            CriarPessoasSemClasse();

            // Aqui crias as pessoas utilizando classe
            CriarPessoasComClasse();

            Console.ReadKey();
        }

        static void CriarPessoasComClasse()
        {
            // Criando a pessoa um com classe
            Pessoa pessoaUm = new Pessoa();

            // Atribuindo os valores para os atributos da pessoa um

            pessoaUm.nome = "Leonardo";
            pessoaUm.sobrenome = "Silva";
            pessoaUm.idade = 28;

            // Chamando o método para exibir a faixa de idade da pessoa um
            pessoaUm.ExibirFaixaIdade();
            
                // Chamando o método para exibir o nome completo da pessoa um
            pessoaUm.ExibirNomeCompleto();

            // Criando a pessoa dois com classe
            Pessoa pessoaDois = new Pessoa();

            // Atribuindo os valores para os atributos da pessoa dois
            pessoaDois.nome = "José";
            pessoaDois.sobrenome = "Machado";

            // Chamando o método para exibir a faixa de idade da pessoa dois
            pessoaDois.ExibirFaixaIdade();
            // Chamando o método para exibir o nome completo da pessoa dois
            pessoaDois.ExibirNomeCompleto();
        }

        static void CriarPessoasSemClasse()
        {
            // Criando a pessoa um
            string nomePessoaUm = "Leonardo";
            string sobrenomePessoaUm = "Silva";
            int idadePessoaUm = 28;

            // Exibindo o nome completo da pessoa um
            Console.WriteLine($"{nomePessoaUm} {sobrenomePessoaUm}");

            // Exibindo a faixa de idade da pessoa um
            if (idadePessoaUm >= 18)
                Console.WriteLine("Maior de idade");
            else
                Console.WriteLine("De menor");

            // Criando a pessoa dois
            string nomePessoaDois = "José";
            string sobrenomePessoaDois = "Machado";
            long idadePessoaDois = 18;

            // Exibindo o nome completo da pessoa dois
            Console.WriteLine($"{nomePessoaDois}-{sobrenomePessoaDois}");

            // Exibindo a faixa de idade da pessoa dois
            if (idadePessoaDois > 18)
                Console.WriteLine("Maior de idade");
            else
                Console.WriteLine("De menor");

            // Criando a pessoa três
            string nomePessoaTres = "Pedro";
            string sobrenomePessoaTres = "Soares";

            // Exibindo o nome completo da pessoa três
            Console.WriteLine($"{sobrenomePessoaTres} {nomePessoaTres}");

            // A pessoa três não possui idade para exibir
        }

    }
}
