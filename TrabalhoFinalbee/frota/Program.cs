using System;

namespace frota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Motorista motorista = new Motorista();
           
            Console.WriteLine(motorista.ObterNomeCompleto());
           
            Veiculo veiculo = CriarVeiculo(null);

            Console.WriteLine(veiculo.ObterDescricao());
            
           

        }
        static Motorista CriarMotorista()
        {
         
            Motorista motorista = new Motorista();

            motorista.nome = "João";
            motorista.sobrenome = "Carlos";
            motorista.cnh = "123456";

            return motorista;
        }
         
        static Veiculo CriarVeiculo(Motorista motorista)
        {
          
            Veiculo veiculo = new Veiculo();
            
            veiculo.modelo = "Polo";
            veiculo.placa = "AAA9999";
            veiculo.proprietario = motorista;

            return veiculo;
        }
    
    }


}
