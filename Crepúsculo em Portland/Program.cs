internal class Program
{
    private static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        int[,] esquinas = new int[N + 1, N + 1];

        for (int i = 0; i < N + 1; i++)
        {
            string[] entradas = Console.ReadLine().Split(' ');

            for (int j = 0; j < N + 1; j++)
            {
                esquinas[i, j] = int.Parse(entradas[j]);
            }
        }

        for (int origemLinha = 0; origemLinha < N; origemLinha++)
        {
            
            for(int origemColuna = 0; origemColuna < N; origemColuna++)
            {
                int uns = 0;

                for (int i = origemLinha; i <= origemLinha + 1; i++)
                {
                    for (int j = origemColuna; j <= origemColuna + 1; j++)
                    {
                        if (esquinas[i, j] == 1)
                            uns++;
                    }
                }

                if (uns >= 2)
                    Console.Write('S');
                else Console.Write('U');
            }
            Console.WriteLine();
        }
    }
}