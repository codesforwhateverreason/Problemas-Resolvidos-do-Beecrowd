internal class Program
{
    private static void Main(string[] args)
    {
        while (int.TryParse(Console.ReadLine(), out int N))
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == N / 2 && j == N / 2)
                        Console.Write(4);
                    else if ((i >= N / 3 && i <= N - (N / 3) - 1) && (j >= N / 3 && j <= N - (N / 3) - 1))
                        Console.Write(1);
                    else if (i == j)
                        Console.Write(2);
                    else if (i + j == N - 1)
                        Console.Write(3);
                    else Console.Write(0);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}