internal class Program
{
    private static void Main(string[] args)
    {
        int gritos = 0;

        while (++gritos <= 3)
        {
            string comando;

            int soma = 0;

            while ((comando = Console.ReadLine()) != "caw caw")
            {
                char[] caract = comando.ToCharArray();
                
                for (int i = 0; i < 3; i++)
                {
                    if (caract[i] == '*')
                        soma += Convert.ToInt32(Math.Pow(2, (2 - i)));                
                }
            }

            Console.WriteLine(soma);
        }
    }
}