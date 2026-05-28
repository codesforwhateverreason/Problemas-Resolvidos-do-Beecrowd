using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        while(true)
        {
            string entrada = Console.ReadLine();

            if (string.IsNullOrEmpty(entrada)) 
                break;

            int[] ordemChegadaCaixas = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] tempoTrocaCaixas = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int resultado = OrganizarCaixas(ordemChegadaCaixas, tempoTrocaCaixas);

            Console.WriteLine(resultado);
        }
    }

    static int OrganizarCaixas(int[] ordem, int[] tempo)
    {
        int tempototal = 0;

        bool organizada = (ordem.Length > 1) ? false : true;

        if (!organizada)
        {
            while (!organizada)
            {
                for (int i = 0; i < ordem.Length - 1; i++)
                {
                    if (ordem[i + 1] < ordem[i])
                    {

                        tempototal += tempo[i] + tempo[i + 1];

                        ordem[i + 1] ^= ordem[i]; //Troca por Xor bitwise só por experimento mesmo
                        ordem[i] ^= ordem[i + 1];
                        ordem[i + 1] ^= ordem[i];

                        tempo[i + 1] ^= tempo[i]; //Aqui a troca de novo :D
                        tempo[i] ^= tempo[i + 1];
                        tempo[i + 1] ^= tempo[i];
                    }

                    for (int j = 0; j < ordem.Length - 1; j++)
                    {
                        if (ordem[j] < ordem[j + 1])
                            organizada = true;
                        else
                        {
                            organizada = false;
                            break;
                        }
                    }
                }
            }

            return tempototal;
        }

        return 0;
    }
}