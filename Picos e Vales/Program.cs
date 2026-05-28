using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        string[] entradas = Console.ReadLine().Split(' ');

        int[] H = Array.ConvertAll(entradas, int.Parse);

        int[] paisagem = new int[N - 1];

        int vista = 1;

        if (H[1] < H[0])
            paisagem[0] = -1;
        else if (H[1] > H[0])
            paisagem[0] = 1;
        else
        {
            vista = 0;
            paisagem[0] = 0;
        }

        for (int i = 2; i < N; i++)
        {
            if (H[i] < H[i - 1] && paisagem[i - 2] == 1)
                paisagem[i - 1] = -1;
            else if (H[i] > H[i - 1] && paisagem[i - 2] == -1)
                paisagem[i - 1] = 1;
            else paisagem[i - 1] = 0;

            if (paisagem[i - 1] == 0)
            {
                vista = 0;
                break;
            }
        }

        Console.WriteLine(vista);
    }
}