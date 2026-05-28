internal class Program
{
    private static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());

        string[] tempo = new string[T];

        for (int i = 0; i < T; i++)
        {
            string entradas = Console.ReadLine();

            string[] numeros = entradas.Split(' ');

            int PA = int.Parse(numeros[0]);
            int PB = int.Parse(numeros[1]);

            decimal G1 = decimal.Parse(numeros[2]);
            decimal G2 = decimal.Parse(numeros[3]);

            int anos = 0;

            while (PA <= PB)
            {

                if (anos++ > 100)
                    break;

                PA = Convert.ToInt32(Math.Floor(Convert.ToDecimal(PA) * (1m + (G1 / 100m))));
                PB = Convert.ToInt32(Math.Floor(Convert.ToDecimal(PB) * (1m + (G2 / 100m))));
            }

            if (anos > 100)
            {
                tempo[i] = "Mais de 1 seculo.";
            }
            else tempo[i] = anos + " anos.";

        }

        foreach (string j in tempo)
        {
            Console.WriteLine(j);
        }
    }
}