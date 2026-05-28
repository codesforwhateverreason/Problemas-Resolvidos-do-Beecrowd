internal class Program
{
    private static void Main(string[] args)
    {
        while (int.TryParse(Console.ReadLine(), out int N))
        {
            string[] entradas = Console.ReadLine().Split(' ');

            int M = int.Parse(entradas[0]);
            int L = int.Parse(entradas[1]);

            int[,] MM = new int[M, N];
            int[,] ML = new int[L, N];

            for (int i = 0; i < M; i++)
            {
                string[] coluna = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {
                    MM[i, j] = int.Parse(coluna[j]);
                }
            }

            for (int i = 0; i < L; i++)
            {
                string[] coluna = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {
                    ML[i, j] = int.Parse(coluna[j]);
                }
            }

            string[] cartas = Console.ReadLine().Split(' ');

            int CM = int.Parse(cartas[0]);
            int CL = int.Parse(cartas[1]);

            int A = int.Parse(Console.ReadLine());

            if (MM[CM - 1, A - 1] > ML[CL - 1, A - 1])
                Console.WriteLine("Marcos");
            else if (ML[CL - 1, A - 1] > MM[CM - 1, A - 1])
                Console.WriteLine("Leonardo");
            else Console.WriteLine("Empate");
        }
    }
}