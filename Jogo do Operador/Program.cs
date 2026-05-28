internal class Program
{
    private static void Main(string[] args)
    {

        while (int.TryParse(Console.ReadLine(), out int T))
        {
            int[] X = new int[T];
            int[] Y = new int[T];
            int[] Z = new int[T];

            for (int i = 0; i < T; i++)
            {
                string[] entradas = Console.ReadLine().Split(' ');

                X[i] = int.Parse(entradas[0]);
                Y[i] = int.Parse(entradas[1].Split('=')[0]);
                Z[i] = int.Parse(entradas[1].Split('=')[1]);
            }

            string[] nomes = new string[T];
            bool[] certo = new bool[T];

            for (int i = 0; i < T; i++)
            {
                string[] entradas = Console.ReadLine().Split(' ');

                nomes[i] = (entradas[0]);
                int indice = int.Parse(entradas[1]) - 1;
                string operador = entradas[2];

                switch (operador)
                {
                    case "+":
                        certo[i] = (X[indice] + Y[indice] == Z[indice]);
                        break;

                    case "-":
                        certo[i] = (X[indice] - Y[indice] == Z[indice]);
                        break;

                    case "*":
                        certo[i] = (X[indice] * Y[indice] == Z[indice]);
                        break;

                    case "I":
                        certo[i] = (X[indice] + Y[indice] != Z[indice] && X[indice] - Y[indice] != Z[indice] && X[indice] * Y[indice] != Z[indice]);
                        break;
                }
            }

            int falharam = certo.Count(a => a == false);

            if (falharam == 0)
                Console.WriteLine("You Shall All Pass!");
            else if (falharam == T)
                Console.WriteLine("None Shall Pass!");
            else
            {

                List<string> perdedores = new List<string>();

                for (int j = 0; j < certo.Length; j++)
                {
                    if (certo[j] == false)
                        perdedores.Add(nomes[j]);
                }

                perdedores.Sort(String.CompareOrdinal);

                Console.WriteLine(string.Join(" ", perdedores));
            }
        }
    }
}