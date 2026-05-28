internal class Program
{
    private static void Main(string[] args)
    {
        while (int.TryParse(Console.ReadLine(), out int M))
        {
            int[] valores = new int[M];

            for (int i = 0; i < M; i++)
                valores[i] = int.Parse(Console.ReadLine());

            int N = int.Parse(Console.ReadLine());

            int soma = 0;

            for (int i = valores.Length - 1; i >= 0; i = i - N)
                soma += valores[i];

            bool primo = true;

            if (soma <= 1)
                primo = false;
            else
            {
                for (int i = 2; i <= Math.Sqrt(soma); i++)
                {
                    if (soma % i == 0)
                    {
                        primo = false;
                        break;
                    }
                }
            }

            Console.WriteLine((primo) ? "You’re a coastal aircraft, Robbie, a large silver aircraft." : "Bad boy! I’ll hit you.");
        }
    }
}