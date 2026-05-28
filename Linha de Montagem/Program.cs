using System;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;

internal class Program
{
    private static void Main(string[] args)
    {
        while(int.TryParse(Console.ReadLine(), out int N))
        {
            int[] entradas = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[,] a = new int[2, N];

            for (int i = 0; i < 2; i++)
            {
                int[] linha = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int j = 0; j < N; j++) 
                    a[i, j] = linha[j];
            }

            int[,] t = new int[2, (N > 1) ? N - 1: 1];

            if (N > 1)
            {
                for (int i = 0; i < 2; i++)
                {
                    int[] linha = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                    for (int j = 0; j < N - 1; j++)
                        t[i, j] = linha[j];
                }
            }

            int[] saidas = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int resultadoLinha1 = entradas[0] + a[0, 0];
            int resultadoLinha2 = entradas[1] + a[1, 0];

            for (int i = 1; i < N; i++)
            {

                int ant1 = resultadoLinha1;
                int ant2 = resultadoLinha2;

                resultadoLinha1 = Math.Min(ant1 + a[0, i], ant2 + t[1, i - 1] + a[0, i]);
                resultadoLinha2 = Math.Min(ant2 + a[1, i], ant1 + t[0, i - 1] + a[1, i]);
            }

            int menor = Math.Min(resultadoLinha1 + saidas[0], resultadoLinha2 + saidas[1]);

            Console.WriteLine(menor);
        }
    }
}