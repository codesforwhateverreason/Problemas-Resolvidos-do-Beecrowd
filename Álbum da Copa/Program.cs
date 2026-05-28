internal class Program
{
    private static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        HashSet<int> cartas = new HashSet<int>();

        int M = int.Parse(Console.ReadLine());

        for (int i = 0; i < M; i++)
        {
            int carta = int.Parse(Console.ReadLine());

            cartas.Add(carta);
        }

        Console.WriteLine(N - cartas.Count);
    }
}