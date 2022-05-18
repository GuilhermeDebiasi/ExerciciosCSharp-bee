using System;

class _1175
{

    static void Main(string[] args)
    {

        int[] vet = new int[20];

        int j = 0;

        for (int i = 0; i < vet.Length; i++)
        {
            vet[i] = int.Parse(Console.ReadLine());
        }

        Array.Reverse(vet);
        foreach (int n in vet)
        {
            Console.WriteLine("N[{0}] = {1}", j, n);
            j++;
        }

    }

}