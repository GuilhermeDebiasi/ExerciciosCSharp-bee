﻿using System;

namespace _1007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor;

            Double.TryParse(Console.ReadLine(), out valor);

            if (0 <= valor && valor <= 25)
            {
                Console.WriteLine("Intervalo [0, 25]");
            }
            else if (25 < valor && valor <= 50)
            {
                Console.WriteLine("Intervalo (25, 50]");
            }
            else if (50 < valor && valor <= 75)
            {
                Console.WriteLine("Intervalo (50, 75]");
            }
            else if (75 < valor && valor <= 100)
            {
                Console.WriteLine("Intervalo (75, 100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }



        }
    }
}
