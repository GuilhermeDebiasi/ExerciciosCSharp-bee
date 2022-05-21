using System;

namespace _1435
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanho = int.Parse(Console.ReadLine());

            int N, up, down, left, right, add, mid;
            int[,] M;

            N = 1;
            while (N != 0)
            {
                
                M = new int[N, N];
                add = 1;
                up = 0;
                down = N - 1;
                left = 0;
                right = N - 1;

                if (N % 2 == 0)
                {
                    mid = N / 2;
                }
                else
                {
                    mid = (N + 1) / 2;
                }

                while (add <= mid)
                {
                    for (int i = left; i <= right; i++)
                    {
                        M[up, i] = add;
                        M[down, i] = add;
                    }
                    for (int i = (up + 1); i < down; i++)
                    {
                        M[i, left] = add;
                        M[i, right] = add;
                    }
                    add++;
                    up++;
                    left++;
                    right--;
                    down--;
                }

                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (j == 0)
                        {
                            Console.Write($"  {M[i, j]}");
                        }
                        else if (M[i, j] > 9)
                        {
                            Console.Write($"  {M[i, j]}");
                        }
                        else
                        {
                            Console.Write($"   {M[i, j]}");
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                N = int.Parse(Console.ReadLine());
            }
        }
    }
}
        
    


