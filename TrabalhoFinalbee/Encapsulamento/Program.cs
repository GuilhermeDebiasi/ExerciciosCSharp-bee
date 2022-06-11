using System;

namespace Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Entidades.Pessoa pessoa = CadastrarPessoa();
            Entidades.ContaBancaria contaBancaria = CadastrarContaBancaria(pessoa);
            Serviços.ContaBancaria servicoContaBancaria = new Serviços.ContaBancaria(contaBancaria)
            int operacao = 0;

            

            do
            {
                Console.Clear();
                Console.WriteLine($"Bem vindo {pessoa.ObterNomeCompleto()}");
                Console.WriteLine("");
                Console.WriteLine("Operações Disponíveis");
                Console.WriteLine("(1) Consultar Saldo");
                Console.WriteLine("(2) Depositar");
                Console.WriteLine("(3) Sacar");
                Console.WriteLine("(9) Sair");
                Console.WriteLine("");
                Console.Write("Informe a operação: ");

                int.TryParse(Console.ReadLine(), out operacao);

                if (operacao == 1)
                {
                    Console.WriteLine($"Seu saldo é: R$ {servicoContaBancaria.ObterSaldoAtual()}");
                }
                else if (operacao == 2)
                {
                    Console.WriteLine($"Informe o valor: ");
                    decimal valorDepositar = 0.0m;
                    decimal.TryParse(Console.ReadLine(), out valorDepositar);
                    servicoContaBancaria.Depositar(valorDepositar);
                }
                else if (operacao == 3)
                {
                    Console.WriteLine($"Informe o valor: ");
                    decimal valorSacar = 0.0m;
                    decimal.TryParse(Console.ReadLine(), out valorSacar);
                    servicoContaBancaria.Sacar(valorSacar)
                }

                if (operacao == 9)
                {
                    Console.WriteLine($"Obrigado {pessoa.Nome}");
                }
                else
                    Console.WriteLine("Operação Inválida");

                Console.ReadKey();
            } while (operacao != 9);

            private static Entidades.ContaBancaria CadastrarContaBancaria(Entidades.Pessoa pessoa)
            {

            }

            private static Entidades.Pessoa CadastrarPessoa()
            {
                Entidades.Pessoa pessoa = new Entidades.Pessoa();

                Console.WriteLine("Cadastro da Conta ");
                Console.Write("Nome: ");
                pessoa.Nome = Console.ReadLine();
                Console.Write("Sobrenome: ");
                pessoa.Sobrenome = Console.ReadLine();
                Console.Write("CPF: ");
                pessoa.Cpf = Console.ReadLine();
            }




            



        }
    }
}
