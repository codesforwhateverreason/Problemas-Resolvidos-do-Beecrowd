internal class Program
{
    private static void Main(string[] args)
    {
        int N;

        while ((N = int.Parse(Console.ReadLine())) > 0)
        {
            int T = Math.Pow(4, N - 1).ToString().Length;

            for (int i = 0; i < N; i++)
            {
                long valor = Convert.ToInt64(Math.Pow(2, i));

                for (int j = 0; j < N; j++)
                { 
                    if (j == 0)
                        Console.Write(valor.ToString().PadLeft(T));
                    else Console.Write(" " + valor.ToString().PadLeft(T));

                    valor *= 2;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}