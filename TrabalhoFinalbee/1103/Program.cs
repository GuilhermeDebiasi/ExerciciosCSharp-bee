using System;

namespace _1103
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h1, m1, h2, m2, tempo;

            while (true) 
            {

              String[] linha = Console.ReadLine().Split(' ');

                h1 = int.Parse(linha[0]);
                m1 = int.Parse(linha[1]);
                h2 = int.Parse(linha[2]);
                m2 = int.Parse(linha[3]);

                if (h1 == 0 && h2 == 0 && m1 == 0 && m2 == 0)
                    break;

                if((h1 > h2) || (h1 == h2) && m1 > m2)
                h2 += 24;

                h1 *= 60;
                h2 *= 60;

                int hora1, hora2;
                hora1 = h1 + m1;
                hora2 = h2 + m2;

                tempo = hora2 - hora1;

                Console.WriteLine($"{tempo}");


            }


        }
    }
}
