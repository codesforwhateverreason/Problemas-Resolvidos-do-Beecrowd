internal class Program
{
    private static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());

        int K = int.Parse(Console.ReadLine());

        int[] pontuacoes = new int[T];

        for (int i = 0; i < T; i++)
            pontuacoes[i] = int.Parse(Console.ReadLine());

        Array.Sort(pontuacoes);
        Array.Reverse(pontuacoes);

        int classificados = 1;
        int ultimacolocacao = pontuacoes[K - 1];

        for (int i = 1; i < T; i++)
            classificados += (pontuacoes[i] >= ultimacolocacao) ? 1 : 0;

        Console.WriteLine(classificados);
    }
}