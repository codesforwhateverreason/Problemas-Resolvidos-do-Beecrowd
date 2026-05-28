internal class Program
{
    private static void Main(string[] args)
    {
        string[] numeros = Console.ReadLine().Split(' ');

        int a = int.Parse(numeros[0]);
        int b = int.Parse(numeros[1]);

        int q = 0, r = 0;

        if (a % b != 0)
        {
            if (a < 0 && b > 0)
            {
                q = (a / b) - 1;
            }
            else if (a < 0 && b < 0)
            {
                q = (a / b) + 1;
            }
            else q = a / b;
        }
        else q = a / b;

        r = a - (b * q);

        Console.WriteLine($"{q} {r}");
    }
}