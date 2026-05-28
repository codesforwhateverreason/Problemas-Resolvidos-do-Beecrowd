internal class Program
{
    private static void Main(string[] args)
    {
        string entrada;

        while ((entrada = Console.ReadLine()) != null)
        {
            string[] numeros = entrada.Split(' ');

            int N = int.Parse(numeros[0]);
            int D = int.Parse(numeros[1]);

            string data = "";

            for (int i = 0; i < D; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                bool possivel = true;

                for (int j = 1; j < input.Length; j++)
                {
                    if (input[j] == "0")
                    {
                        possivel = false;
                        break;
                    }
                }

                if (possivel && data == "")
                    data = input[0];
            }

            if (data != "")
                Console.WriteLine(data);
            else Console.WriteLine("Pizza antes de FdI");
        }
    }
}