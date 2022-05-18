
using System;

namespace _1914
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int jogadores, numero, par, impar, jogada1, jogada2;
            string nomes, jogada;

            int.TryParse(Console.ReadLine(), out jogadores);

            for (int i = 0; i < jogadores; i++)
            {
                nomes = Console.ReadLine();
                jogada = Console.ReadLine();
                var vetorJogadas = jogada.Split(' ');

                

                int.TryParse(vetorJogadas[0], out jogada1);
                int.TryParse(vetorJogadas[1], out jogada2);






            }
        }

    }
}
