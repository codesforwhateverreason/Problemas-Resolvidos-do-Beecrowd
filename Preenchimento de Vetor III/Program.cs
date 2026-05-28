internal class Program
{
    private static void Main(string[] args)
    {
        decimal[] N = new decimal[100];

        decimal X = decimal.Parse(Console.ReadLine());

        N[0] = X;

        for (int i = 1; i <= 100; i++)
        {
            if (i != 6)
                Console.WriteLine("N[{0}] = {1:f4}", i - 1, N[i - 1]);
            else Console.WriteLine("N[{0}] = {1:f4}", i - 1, N[i - 1] - 0.0001m);


            if (i == 100)
                break;

            N[i] = N[i - 1] / 2m;
        }
    }
}