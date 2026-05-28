internal class Program
{
    private static void Main(string[] args)
    {
        int L = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());


        int tipo1 = (L * C) + ((L - 1) * (C - 1));
        int tipo2 = ((L - 1) + (C - 1)) * 2;

        Console.WriteLine(tipo1);
        Console.WriteLine(tipo2);
    }
}