internal class Program
{
    private static void Main(string[] args)
    {
        int[] par = new int[5];
        int[] impar = new int[5];
        int indexpar = 0, indeximpar = 0;

        for (int i = 0; i < 15; i++)
        {
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                par[indexpar] = numero;
                indexpar++;

                if (indexpar == 5)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine("par[{0}] = {1}", j, par[j]);
                    }
                    indexpar = 0;
                }
            }
            else
            {
                impar[indeximpar] = numero;
                indeximpar++;

                if (indeximpar == 5)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine("impar[{0}] = {1}", j, impar[j]);
                    }
                    indeximpar = 0;
                }
            }
        }

        for (int i = 0; i < indeximpar; i++)
        {
            Console.WriteLine("impar[{0}] = {1}", i, impar[i]);
        }

        for (int i = 0; i < indexpar; i++)
        {
            Console.WriteLine("par[{0}] = {1}", i, par[i]);
        }
    }
}