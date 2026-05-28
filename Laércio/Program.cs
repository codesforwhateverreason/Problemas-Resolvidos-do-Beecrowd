internal class Program
{
    private static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            int M = int.Parse(Console.ReadLine());

            int[] sequencia = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] impares = sequencia.Where(x => x % 2 == 1).OrderBy(x => x).ToArray();

            /*
             * Foi 10 ms mais lento
            int[] ordem = Enumerable.Range(0, impares.Length).Select(x => (x % 2 == 0) ? impares[fim--] : impares[inicio++]).ToArray();
            */

            // Método mais rápido

            int[] ordem = new int[impares.Length];

            int inicio = 0, fim = ordem.Length - 1;

            for (int j = 0; j < ordem.Length; j++)
                ordem[j] = (j % 2 == 0) ? impares[fim--] : impares[inicio++];


            Console.WriteLine(string.Join(" ", ordem));

        }
    }
}