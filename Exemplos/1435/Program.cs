using System;

namespace _1435
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanho = int.Parse(Console.ReadLine());

            while (tamanho != 0)
            {
                int[,] matriz = new int[tamanho, tamanho];
                for (int i = 0; i < tamanho; i++)
                {
                    for (int j = i; j < (tamanho - i); j++)
                    {
                        matriz[i, j] = i + 1;
                        matriz[tamanho - 1 - i, j] = i + 1;
                    }
                }


                for (int i = 0; i < tamanho; i++)
                {
                    for (int j = 0; j < tamanho; j++)
                    {

                        string temp = matriz[i, j].ToString();
                        if (temp.Length == 1)
                        {
                            temp = "  " + temp;
                        }
                        else
                        {
                            if (temp.Length == 2)
                            {
                                temp = " " + temp;
                            }
                        }
                        if (j == tamanho - 1)
                        {
                            Console.WriteLine(temp);
                        }
                        else
                        {
                            Console.Write(temp + " ");
                        }


                    }
                }
            } 
        }
    }
}

