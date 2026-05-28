internal class Program
{
    private static void Main(string[] args)
    {

        while (int.TryParse(Console.ReadLine(), out int M))
        {
            double numerador = 0, denominador = 0;

            for (int i = 0; i < M; i++)
            {
                string[] numeros = Console.ReadLine().Split(' ');

                int N = int.Parse(numeros[0]);
                int C = int.Parse(numeros[1]);

                numerador += N * C;
                denominador += C;
            }

            denominador *= 100;

            double IRA = numerador / denominador;

            Console.WriteLine($"{IRA:f4}");
        }
    }
}