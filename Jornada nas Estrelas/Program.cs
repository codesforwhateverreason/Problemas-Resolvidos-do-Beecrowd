internal class Program
{
    private static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        string[] entradas = Console.ReadLine().Split(' ');

        long[] numeros = Array.ConvertAll(entradas, long.Parse);

        long soma = 0;
        int maior = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            if (i < 0 || i >= numeros.Length)
                break;

            if (i > maior)
                maior = i;

            if (numeros[i]-- % 2 == 0)
                i -= 2;
        }

        foreach (long num in numeros)
        { 
            if (num > 0)
                soma += num;
        }
            

        Console.WriteLine($"{maior + 1} {soma}");
    }
}