internal class Program
{
    private static void Main(string[] args)
    {
        string entrada;

        while ((entrada = Console.ReadLine()) != null)
        {
            int N = int.Parse(entrada.Split(' ')[0]);
            int M = int.Parse(entrada.Split(' ')[1]);

            int posXpokemon = 0, posYpokemon = 0;
            int posXtreinador = 0, posYtreinador = 0;

            for (int i = 0; i < N; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');
                for (int j = 0; j < M; j++)
                {
                    int espaco = int.Parse(linha[j]);

                    if (espaco == 2)
                    {
                        posXpokemon = i;
                        posYpokemon = j;
                    } else if (espaco == 1)
                    {
                        posXtreinador = i;
                        posYtreinador = j;
                    }
                }
            }

            int resultado = Math.Abs((posXpokemon - posXtreinador)) + Math.Abs((posYpokemon - posYtreinador));

            Console.WriteLine(resultado);
        }
    }
}