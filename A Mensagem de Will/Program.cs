internal class Program
{
    private static void Main(string[] args)
    {

        string alfabeto;

        while ((alfabeto = Console.ReadLine()) != null)
        {
            char[] letras = alfabeto.ToCharArray();

            int q = int.Parse(Console.ReadLine());

            char[] traducao = new char[q];

            string[] entradas = Console.ReadLine().Split(' ');

            int[] numeros = Array.ConvertAll(entradas, int.Parse);

            for (int i = 0; i < q; i++)
            {

                traducao[i] = letras[numeros[i] - 1];
            }

            string resultado = new string(traducao);

            Console.WriteLine(resultado);
        }
    }
}