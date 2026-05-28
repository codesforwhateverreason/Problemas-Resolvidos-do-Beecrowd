using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> sequencia = new List<string>();

        int N;

        do
        {
            N = int.Parse(Console.ReadLine());

            string saida = "";

            if (N > 0)
            {
                for (int i = 1; i <= N; i++)
                {
                    saida += i;

                    if (i != N)
                    {
                        saida += " ";
                    }
                }
                sequencia.Add(saida);
            }

        } while (N > 0);

        foreach (string i in sequencia)
        {
            Console.WriteLine(i);
        }
    }
}