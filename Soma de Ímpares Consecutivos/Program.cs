internal class Program
{
    private static void Main(string[] args)
    {
        int x, y, soma = 0;

        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());

        int mod;

        if (x % 2 == 1 || x % 2 == -1)
        {
            if (x > 0)
            {
                x--;
            }
            else if (x < 0)
            {
                x++;
            }
        }

        if (y % 2 == 1 || y % 2 == -1)
        {
            if (y > 0)
            {
                y--;
            }
            else if (y < 0)
            {
                y++;
            }
        }


        if (y < x)
        {
            for (int i = x; i > y; i--)
            {
                mod = ((i % 2) + 2) % 2;

                if (mod == 1)
                {
                    soma += i;
                }
            }
        }
        else if (y > x)
        {
            for (int i = x; i < y; i++)
            {
                mod = ((i % 2) + 2) % 2;

                if (mod == 1)
                {
                    soma += i;
                }
            }
        }

        Console.WriteLine(soma);
    }
}