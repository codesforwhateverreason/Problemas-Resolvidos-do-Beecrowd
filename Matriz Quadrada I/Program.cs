using System.Drawing;

internal class Program
{
    private static void Main(string[] args)
    {
        int N;

        do
        {
            N = int.Parse(Console.ReadLine());

            if (N > 0)
            {

                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        int valor = Math.Min(Math.Min(i + 1, j + 1), Math.Min(N - i, N - j));

                        if (j == 0)
                            Console.Write("{0,3}", valor);
                        else
                            Console.Write(" {0,3}", valor);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        } while (N > 0);
    }
}