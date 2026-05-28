internal class Program
{
    private static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        int[] numeros = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        if (numeros.Length > 2)
        {
            int escadinhas = 0;

            int diff = numeros[1] - numeros[0];

            int i = 2;

            while (i < numeros.Length)
            {

                while (numeros[i] - numeros[i - 1] == diff)
                {
                    i++;

                    if (i >= numeros.Length)
                        break;
                }

                escadinhas++;

                if (i >= numeros.Length)
                    break;

                diff = numeros[i] - numeros[i - 1];
            }

            Console.WriteLine(escadinhas);
        }
        else Console.WriteLine(1);
    }
}