internal class Program
{
    private static void Main(string[] args)
    {
        string[] entradas = Console.ReadLine().Split(' ');

        int N = int.Parse(entradas[0]);
        int M = int.Parse(entradas[1]);

        int[,] terreno = new int[N, M];

        bool padrao = false;
        int posX = 0, posY = 0;

        for (int a = 0; a < N; a++)
        {
            string[] inputs = Console.ReadLine().Split(' ');

            int[] numeros = Array.ConvertAll(inputs, int.Parse);

            for (int b = 0; b < M; b++)
            {
                terreno[a, b] = numeros[b];
            }
        }

        for (int i = 1; i < N - 1; i++)
        {
            for (int j = 1; j < M - 1; j++)
            {
                if (terreno[i, j] == 42)
                {
                    int setes = 0;

                    for (int k = i - 1; k <= i + 1; k++)
                    {
                        for (int l = j - 1; l <= j + 1; l++)
                        {
                            if (terreno[k, l] == 7)
                                setes++;
                        }
                    }

                    if (setes == 8)
                    {
                        padrao = true;
                        posX = i + 1;
                        posY = j + 1;
                    }
                }
                if (padrao == true)
                    break;
            }
            if (padrao == true)
                break;
        }

        Console.WriteLine(padrao ? $"{posX} {posY}" : "0 0");
    }
}