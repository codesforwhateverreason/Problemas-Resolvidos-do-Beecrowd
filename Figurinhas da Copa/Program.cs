internal class Program
{
    private static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');

        int C = int.Parse(inputs[1]);

        int[] figurinhascarimbadas = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        HashSet<int> cartas = Console.ReadLine().Split(' ').Select(int.Parse).ToHashSet();

        foreach (int carta in cartas)
        {
            if (figurinhascarimbadas.Contains(carta))
                C--;
        }

        Console.WriteLine(C);
    }
}