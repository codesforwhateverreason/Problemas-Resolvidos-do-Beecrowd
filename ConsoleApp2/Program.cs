internal class Program
{
    private static void Main(string[] args)
    {
        float valor = float.Parse(Console.ReadLine());

        Console.WriteLine("NOTAS:");

        Console.WriteLine("{0} nota(s) de R$ 100.00", Math.Floor(valor / 100));

        valor %= 100;

        Console.WriteLine("{0} nota(s) de R$ 50.00", Math.Floor(valor / 50));

        valor %= 50;

        Console.WriteLine("{0} nota(s) de R$ 20.00", Math.Floor(valor / 20));

        valor %= 20;

        Console.WriteLine("{0} nota(s) de R$ 10.00", Math.Floor(valor / 10));

        valor %= 10;

        Console.WriteLine("{0} nota(s) de R$ 5.00", Math.Floor(valor / 5));

        valor %= 5;

        Console.WriteLine("{0} nota(s) de R$ 2.00", Math.Floor(valor / 2));

        valor %= 2;

        Console.WriteLine("MOEDAS:");

        Console.WriteLine("{0} moeda(s) de R$ 1.00", Math.Floor(valor / 1));

        valor %= 1;

        Console.WriteLine("{0} moeda(s) de R$ 0.50", Math.Floor(valor / 0.5));

        valor %= 0.5f;

        Console.WriteLine("{0} moeda(s) de R$ 0.25", Math.Floor(valor / 0.25));

        valor %= 0.25f;

        Console.WriteLine("{0} moeda(s) de R$ 0.10", Math.Floor(valor / 0.1));

        valor %= 0.1f;

        Console.WriteLine("{0} moeda(s) de R$ 0.05", Math.Floor(valor / 0.05));

        valor %= 0.05f;

        Console.WriteLine("{0} moeda(s) de R$ 0.01", Math.Round(valor / 0.01));
    }
}