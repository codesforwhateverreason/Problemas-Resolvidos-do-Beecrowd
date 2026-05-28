internal class Program
{
    private static void Main(string[] args)
    {
        string[] entradas = Console.ReadLine().Split(' ');

        int P = int.Parse(entradas[0]);
        int N = int.Parse(entradas[1]);

        int[] pulos = new int[N];

        string[] numeros = Console.ReadLine().Split(' ');

        pulos = Array.ConvertAll(numeros, int.Parse);

        int anterior = pulos[0];

        bool ganhou = true;

        for (int i = 1; i < N; i++)
        {
            if (Math.Abs(pulos[i] - anterior) > P)
            {
                ganhou = false;
                break;
            }
            anterior = pulos[i];
        }

        if (ganhou == true)
        {
            Console.WriteLine("YOU WIN");
        }
        else Console.WriteLine("GAME OVER");
    }
}