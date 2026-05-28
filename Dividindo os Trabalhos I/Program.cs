internal class Program
{
    private static void Main(string[] args)
    {
        string entrada;

        while ((entrada = Console.ReadLine()) != null)
        {
            if (String.IsNullOrEmpty(entrada)) 
                continue;

            string[] entradas = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            long[] trabalhos = Array.ConvertAll(entradas, long.Parse);

            long diferenca = trabalhos.Sum();
            long menor = diferenca;

            foreach (long trabalho in trabalhos)
            {
                diferenca -= 2 * trabalho;
                menor = (Math.Abs(diferenca) < menor) ? Math.Abs(diferenca) : menor;
            }

            Console.WriteLine(menor);
        }
    }
}