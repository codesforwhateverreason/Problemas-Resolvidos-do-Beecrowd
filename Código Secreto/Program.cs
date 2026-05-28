internal class Program
{
    private static void Main(string[] args)
    {
        while(int.TryParse(Console.ReadLine(), out int N))
        {
            for (int i = 0; i < N; i++)
            {
                string[] numero = Console.ReadLine().Split(' ');

                int inicio = 0;

                switch (numero[0])
                {
                    case ".":
                        inicio = 1;
                        break;

                    case "..":
                        inicio = 2;
                        break;

                    case "...":
                        inicio = 3;
                        break;
                }

                Console.WriteLine((char)((inicio + ((numero.Length - 1) * 3)) + 96));
            }
        }
    }
}