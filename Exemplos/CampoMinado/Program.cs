using System;

namespace CampoMinado
{
     class Program
    {
       

        static void Main(string[] args)
        {
            int valor;
            int[] posicaoVetor;
            posicaoVetor = new int[10];

            int.TryParse(Console.ReadLine(), out valor);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"N[{i}] = {valor}");
                valor = 2 * valor;
            }
        }
        

  
    
    
    
    
    
    
    
    
    }


}