using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            int T = int.Parse(Console.ReadLine());

            string[] toxicos = new string[T];

            for (int j = 0; j < T; j++)
                toxicos[j] = Console.ReadLine();

            int U = int.Parse(Console.ReadLine());

            for (int j = 0; j < U; j++)
            {
                string composto = Console.ReadLine();

                bool abortar = false;

                foreach (string quimico in toxicos)
                {
                    for (int k = 0; k <= composto.Length - quimico.Length; k++)
                    {
                        if (composto.Substring(k, quimico.Length) == quimico)
                        {
                            if (k + quimico.Length < composto.Length)
                            {
                                if (!char.IsDigit(composto[k + quimico.Length]) && char.IsUpper(composto[k + quimico.Length]))
                                {
                                    abortar = true;
                                    break;
                                }
                            } else
                            {
                                abortar = true;
                                break;
                            }
                        
                        }
                    }
                }

                Console.WriteLine((abortar) ? "Abortar" : "Prossiga");
            }

            if (i != N - 1)
                Console.WriteLine();
        }
    }
}