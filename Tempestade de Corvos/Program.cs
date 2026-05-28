internal class Program
{
    private static void Main(string[] args)
    {
        string S;

        while ((S = Console.ReadLine()) != null)
        {
            string[] entradas = S.Split(' ');

            int Xf = int.Parse(entradas[0]);
            int Yf = int.Parse(entradas[1]);
            int Xi = int.Parse(entradas[2]);
            int Yi = int.Parse(entradas[3]);
            int Vi = int.Parse(entradas[4]);
            int R1 = int.Parse(entradas[5]);
            int R2 = int.Parse(entradas[6]);

            double distancia = Math.Sqrt(Math.Pow((Xf - Xi), 2) + Math.Pow((Yf - Yi), 2)) + (Vi * 1.5);

            bool ataque = (distancia <= (R1 + R2)) ? true : false;

            Console.WriteLine(ataque ? "Y" : "N");
        }
    }
}
