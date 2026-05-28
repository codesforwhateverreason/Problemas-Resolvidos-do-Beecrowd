internal class Program
{
    private static void Main(string[] args)
    {
        string[] renas = { "Dasher", "Dancer", "Prancer", "Vixen", "Comet", "Cupid", "Donner", "Blitzen", "Rudolph" };

        int[] bolasdeneve = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine(renas[((bolasdeneve.Sum() % 9) + 8) % 9]);

    }
}