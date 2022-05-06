using System;

namespace _1060
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num, media, total = 0;
            int positivo = 0;


            for (int i = 1; i <= 6; i++)
            {
                Double.TryParse(Console.ReadLine(), out num);
                if (num > 0)
                {
                    positivo++;   // positivo = positivo + 1;
                    positivo = positivo + 1;
                    total = total + num;
                }
               

            }

            Console.WriteLine(positivo + " valores positivos");
           
           
        }
    }
}
