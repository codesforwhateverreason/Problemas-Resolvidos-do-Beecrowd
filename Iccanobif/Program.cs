internal class Program
{
    private static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        int[] sequencia = new int[N];

        sequencia[0] = 1;

        if (sequencia.Length > 1)
        {
            sequencia[1] = 1;

            for (int i = 2; i < sequencia.Length; i++)
                sequencia[i] = sequencia[i - 1] + sequencia[i - 2];

            Array.Reverse(sequencia);
        }

        Console.WriteLine(string.Join(" ", sequencia));
    }


}