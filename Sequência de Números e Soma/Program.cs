internal class Program
{
    private static void Main(string[] args)
    {
        int casos = 0;

        List<int> M = new List<int>();
        List<int> N = new List<int>();

        do
        {
            casos++;
            string entradas = Console.ReadLine();

            string[] numeros = entradas.Split(' ');

            M.Add(int.Parse(numeros[0]));
            N.Add(int.Parse(numeros[1]));

        } while (M[casos - 1] > 0 && N[casos - 1] > 0);


        for (int i = 0; i < (casos - 1); i++)
        {
            int soma = 0;

            int maior = M[i], menor = N[i];

            if (M[i] < N[i])
            {
                menor = M[i];
                maior = N[i];
            }

            for (int j = menor; j <= maior; j++)
            {
                soma += j;
                Console.Write(j + " ");
            }

            Console.WriteLine("Sum={0}", soma);
        }
    }
}