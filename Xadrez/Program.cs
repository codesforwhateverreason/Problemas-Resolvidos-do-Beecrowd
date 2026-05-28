internal class Program
{
    private static void Main(string[] args)
    {
        int L = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());

        if (C % 2 == 0)
        {
            if (L % 2 == 0)
                Console.WriteLine(1);
            else Console.WriteLine(0);
        }
        else
        {
            if (L % 2 == 1)
                Console.WriteLine(1);
            else Console.WriteLine(0);
        }
    }
}