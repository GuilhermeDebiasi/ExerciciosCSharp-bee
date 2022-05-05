using System;

namespace ObterNumeroPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool primo = true;

            // vamos solicitar um número inteiro positivo
            Console.Write("Informe um número inteiro positivo: ");
            int numero = int.Parse(Console.ReadLine());

            // o número é negativo?
            if (numero < 0)
            {
                Console.WriteLine("Número inválido.");
            }
            // é 0 ou 1?
            else if ((numero == 0) || (numero == 1))
            {
                Console.WriteLine("Número válido, mas não é primo.");
            }
            // passou até aqui. Vamos testar se o número é primo
            else
            {
                for (int i = 2; i <= (numero / 2); i++)
                {
                    // se passar no teste, não é primo
                    if (numero % i == 0)
                    {
                        primo = false; // recebe false
                        break;
                    }
                }

                if (primo)
                {
                    Console.WriteLine("O número informado é primo");
                }
                else
                {
                    Console.WriteLine("O número informado não é primo");
                }
            }

            Console.WriteLine("\n\nPressione qualquer tecla para sair...");
            // pausa o programa
            Console.ReadKey();
        }
    }
}