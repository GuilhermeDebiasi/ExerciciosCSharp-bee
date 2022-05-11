using System;

namespace _1067
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num;
            Double.TryParse(Console.ReadLine(), out num);

            for (num = 0; num <= 50; num++)
            {
                

                if (num % 2 == 1)
                {
                    Console.WriteLine(num);
                }


                
            }

        }
    }
}
