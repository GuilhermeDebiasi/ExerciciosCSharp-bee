using System;

namespace frota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            motorista motora = new motorista();

            Console.WriteLine("Digite sua CNH:");
            motora.cnh = Console.ReadLine();
            Console.WriteLine("Digite seu nome: ");
            motora.nome = Console.ReadLine();
            Console.WriteLine("Digite seu Sobrenome");
            motora.sobrenome = Console.ReadLine();
            
                

            motora.ObterNomeCompleto(motora.nome, motora.sobrenome);

            veiculo veiculo = new veiculo();

            Console.WriteLine("Digita sua placa:");
            veiculo.placa = Console.ReadLine();
            Console.WriteLine("Digita o modelo:");
            veiculo.modelo = Console.ReadLine();
            Console.WriteLine("Digita a marca do seu veiculo:");
            veiculo.marca = Console.ReadLine();

            Console.WriteLine(veiculo.ObterDescricao(veiculo.placa, veiculo.modelo));

            Console.ReadKey();
        }
    }
}
