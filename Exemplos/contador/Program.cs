using System;

namespace contador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1 = 0, numero2 = 0, resultado = 0;
            int contador;

            contador = 0;
            numero1 = 0;
            for (contador = 0, numero1 = 0; contador <= 100; contador += 2)
            {
                if (contador % 2 == 0)
                {
                    numero1 = contador * 3;
                    Console.WriteLine("Contador é par");
                }
                else
                {
                    numero2 = contador + 9;
                }

            }

        }
    }
}
