internal class Program
{
    private static void Main(string[] args)
    {
        string A;
        int caso = 1;

        while((A = Console.ReadLine()) != null)
        {
            string B = Console.ReadLine();

            int i = 0, subseq = 0, pos = 0; 

            while (i < B.Length)
            {
                if ((B.Length - i) >= A.Length)
                {
                    if (B.Substring(i, A.Length) == A) 
                    {
                        subseq++;
                        pos = i + 1;
                        i += A.Length;
                    } else i++;
                } else i++;
                    
            }

            Console.WriteLine($"Caso #{caso++}:");

            if (subseq > 0)
            {
                Console.WriteLine($"Qtd.Subsequencias: {subseq}");
                Console.WriteLine($"Pos: {pos}");
            }
            else Console.WriteLine("Nao existe subsequencia");

            Console.WriteLine();
                    
        }


    }
}