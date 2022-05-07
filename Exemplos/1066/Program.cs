using System;

namespace _1066
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num, par = 0, impar = 0, pos = 0, neg = 0;



            for (int i = 1; i <= 5; i++)
            {
                Double.TryParse(Console.ReadLine(), out num);

                if (num % 2 == 0)
                {
                    par++;
                }

                else
                {
                    impar++;
                }

                if (num > 0)
                {
                    pos++;
                }

                else if (num < 0)
                {
                    neg++;
                }


            } 
                Console.WriteLine(par + " valo(es) par(es)");
                Console.WriteLine(impar + " valor(es) impar(es)");
                Console.WriteLine(pos + "valor(es) par(es)");
                Console.WriteLine(neg + " valor(es) negativos");
           
                
                      
                

            
            




        }
    }
}
