internal class Program
{
    private static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());

        string[] pesquisasfeitas = new string[T];

        for (int i = 0; i < T; i++)
            pesquisasfeitas[i] = Console.ReadLine();

        T = int.Parse(Console.ReadLine());

        for (int i = 0; i < T; i++)
        { 
            string consulta = Console.ReadLine();

            int completar = 0;
            string maior = "";

            foreach (string a in pesquisasfeitas)
            {
                if (a.StartsWith(consulta))
                {
                    completar++;
                    maior = (a.Length > maior.Length) ? a : maior;
                }
            }

            if (completar > 0)
                Console.WriteLine($"{completar} {maior.Length}");
            else Console.WriteLine(-1);

        }
    }
}