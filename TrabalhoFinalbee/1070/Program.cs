using System;

namespace _1067
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int.TryParse(Console.ReadLine(), out num);

            for (int i = num; i < num + 12; i++)
            {


                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }



            }

        }
    }
}
