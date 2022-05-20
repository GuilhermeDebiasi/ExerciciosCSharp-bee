
using System;

namespace _1914
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int jogados, nm1, nm2, soma, valor1, valor2; 
            string jogada, valores;


            int.TryParse(Console.ReadLine(), out jogados);

            for (int i = 0; i < jogados; i++)
            {
                
                jogada = Console.ReadLine();
                var vetorJogadas = jogada.Split(' ');

                int.TryParse(vetorJogadas[0], out nm1);
                int.TryParse(vetorJogadas[2], out nm2);


                valores = Console.ReadLine();
                var vetorValores = valores.Split(' ');

                int.TryParse(vetorValores[0], out valor1);
                int.TryParse(vetorValores[1], out valor2);

              
                soma = valor1 + valor2;

                if (soma %2 == 0)
                {
                   if (vetorJogadas[1] == "PAR")
                    {
                        Console.WriteLine($"{vetorJogadas[0]}");
                    }
                    else if(vetorJogadas[3] == "PAR")
                    {
                        Console.WriteLine($"{vetorJogadas[2]}");
                    }
                
                
                }

                else if (soma %2 == 1)
                {
                    if(vetorJogadas[1] == "IMPAR")
                    {
                        Console.WriteLine($"{vetorJogadas[0]}");
                    }
                    else if(vetorJogadas[3] == "IMPAR")
                    {
                        Console.WriteLine($"{vetorJogadas[2]}");
                    }
                
                
                
                }
             
                    
            }
        }

    }
}
