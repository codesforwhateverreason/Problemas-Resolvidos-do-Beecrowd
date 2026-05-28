

internal class Program
{
    private static void Main(string[] args)
    {
        string entrada;

        while ((entrada = Console.ReadLine()) != null)
        {
            string[] numeros = entrada.Split(' ');

            int N = int.Parse(numeros[0]);
            int M = int.Parse(numeros[1]);

            int[,] matriz = new int[N, M];

            for (int i = 0; i < N; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');
                for (int j = 0; j < M; j++)
                {
                    matriz[i, j] = int.Parse(linha[j]);
                }
            }



            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (matriz[i, j] == 1)
                        Console.Write(9);
                    else
                    {
                        int adjacente = 0;

                        if (i - 1 >= 0)
                        {
                            if (matriz[i - 1, j] == 1)
                                adjacente++;
                        }

                        if (i + 1 < N)
                        {
                            if (matriz[i + 1, j] == 1)
                                adjacente++;
                        }

                        if (j - 1 >= 0)
                        {
                            if (matriz[i, j - 1] == 1)
                                adjacente++;
                        }

                        if (j + 1 < M)
                        {
                            if (matriz[i, j + 1] == 1)
                                adjacente++;
                        }

                        Console.Write(adjacente);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}