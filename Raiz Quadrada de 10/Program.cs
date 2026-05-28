internal class Program
{
    private static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        double soma = 3, fracao = 1d / 6d;

            for (int i = N; i > 1; i--) 
            {
                fracao = 1d / (6d + fracao);
            }

        if (N > 0)
            soma += fracao;

        Console.WriteLine($"{soma:f10}");
    }
}