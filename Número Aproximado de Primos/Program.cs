internal class Program
{
    private static void Main(string[] args)
    {
        double n = double.Parse(Console.ReadLine());

        double P = n / Math.Log(n);
        double M = P * 1.25506;

        Console.WriteLine($"{P:f1} {M:f1}");
    }
}