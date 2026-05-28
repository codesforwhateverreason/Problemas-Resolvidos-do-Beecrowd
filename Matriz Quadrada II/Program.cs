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
                        if (j == 0)
                            Console.Write("{0,3}", Math.Abs(i - j) + 1);
                        else Console.Write(" {0,3}", Math.Abs(i - j) + 1);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        } while (N > 0);
    }
}