

internal class Program
{
    private static void Main(string[] args)
    {
        string entrada;

        while ((entrada = Console.ReadLine()) != null)
        {
            string[] numeros = entrada.Split(' ');

            int C = int.Parse(numeros[0]);
            int N = int.Parse(numeros[1]);

            string palavraum = Console.ReadLine();
            string palavradois = Console.ReadLine();

            for (int i = 1; i <= N; i++)
            {
                char[] letras = Console.ReadLine().ToCharArray();

                for (int j = 0; j < letras.Length; j++) 
                {
                    for (int k = 0; k < palavradois.Length; k++)
                    {
                        if (char.ToLower(letras[j]) == char.ToLower(palavradois[k]))
                        {
                            if (char.IsUpper(letras[j]))
                            {
                                letras[j] = char.ToUpper(palavraum[k]);
                            } else letras[j] = char.ToLower(palavraum[k]);
                        } else if (char.ToLower(letras[j]) == char.ToLower(palavraum[k]))
                        {
                            if (char.IsUpper(letras[j]))
                            {
                                letras[j] = char.ToUpper(palavradois[k]);
                            }
                            else letras[j] = char.ToLower(palavradois[k]);
                        }
                    }
                }
                string descriptografado = new string(letras);
                Console.WriteLine(descriptografado);
            }
            Console.WriteLine();
        }
    }
}