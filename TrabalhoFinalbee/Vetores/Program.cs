using System;

namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*FAÇA UM PROGRAMA QUE LEIA
             * UM NUMERO X
             * E NA SEQUENCIA LEIA X
             * VALORES
             * DEPOIS IMPRIMA, DE TRAZ
             * PARA FRENTE OS VALORES 
             * LIDOS
             */

            int X, n;
            int[] valor;
            
            int.TryParse(Console.ReadLine(), out X);
            valor = new int[X];

            for (int i = 0; i < X; i++)
            {
                int.TryParse(Console.ReadLine(), out n);
                valor[i] = n;
            }
            for (int i = X-1; i >= 0; i--)
            {
                Console.WriteLine(valor[i]);
            }





         

           











        }
    }
}
