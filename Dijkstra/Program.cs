internal class Program
{
    private static void Main(string[] args)
    {
        List<string> tipos = new List<string>();

        string entrada;

        int contar = 0;

        while ((entrada = Console.ReadLine()) != null)
        {
            if (!tipos.Contains(entrada))
            {
                contar++;
                tipos.Add(entrada);
            }

        }

        Console.WriteLine(contar);


        //Outra possível solução (Mais rápida)
        /*
        string joia;

        HashSet<string> joias = new HashSet<string>();
        while ((joia = Console.ReadLine()) != null)
        {
            joias.Add(joia);
        }

        Console.WriteLine(joias.Count);
        */
    }
}
}