internal class Program
{
    private static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine()); 

        for (int i = 0; i < N; i++)
        {
            long numero = long.Parse(Console.ReadLine());

            string binario = Convert.ToString(numero, 2);

            int sequencia = 0, maiorSequencia = 0;

            foreach (char a in binario)
            {

                if (a == '1')
                {
                    sequencia++;
                    maiorSequencia = (sequencia > maiorSequencia) ? sequencia : maiorSequencia;
                }
                else
                {
                    maiorSequencia = (sequencia > maiorSequencia) ? sequencia : maiorSequencia;
                    sequencia = 0;
                }
            }

            Console.WriteLine(maiorSequencia);
        } 
    }
}