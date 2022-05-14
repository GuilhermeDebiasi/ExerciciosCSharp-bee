using System;

namespace _1072
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorX, valorN, valorIN = 0, ValorOUT = 0;

            int.TryParse(Console.ReadLine(), out valorN);

            for (int i = 0; i < valorN; i++)
            {
                int.TryParse((Console.ReadLine()), out valorX);

                if (10 <= valorX && valorX <= 20)
                {
                    valorIN++;
                }
                else
                {
                    ValorOUT++;
                }
            }

            Console.WriteLine(valorIN + " in");
            Console.WriteLine(ValorOUT + " out");
       
        }


    }
}
