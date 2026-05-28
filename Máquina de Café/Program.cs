internal class Program
{
    private static void Main(string[] args)
    {
        int[] andares = new int[3];

        for (int i = 0; i < 3; i++)
            andares[i] = int.Parse(Console.ReadLine());

        int[] minutos = new int[3];

        for (int i = 0; i < 3; i++)
            minutos[i] = (andares[(i + 1) % 3] * Math.Abs(((i + 1) % 3) - i) * 2) + (andares[(i + 2) % 3] * Math.Abs(((i + 2) % 3) - i) * 2);

        Array.Sort(minutos);

        Console.WriteLine(minutos[0]);
    }
}