internal class Program
{
    private static void Main(string[] args)
    {
        string entradas = Console.ReadLine();

        string[] numeros = entradas.Split(' ');

        double[] lados = Array.ConvertAll(numeros, double.Parse);

        Array.Sort(lados);
        Array.Reverse(lados);
        

        double A = lados[0];
        double B = lados[1];
        double C = lados[2];

        string triangulo = "";
        string angulo = "";

        if (A >= (B + C))
        {
            Console.WriteLine("NAO FORMA TRIANGULO");
        }
        else
        {

            if ((A * A) == ((B * B) + (C * C)))
            {
                angulo = "RETANGULO";
            }
            else if ((A * A) > ((B * B) + (C * C)))
            {
                angulo = "OBTUSANGULO";
            }
            else if ((A * A) < ((B * B) + (C * C)))
            {
                angulo = "ACUTANGULO";
            }

            Console.WriteLine("TRIANGULO {0}", angulo);

            if (A == B && B == C && C == A)
            {
                triangulo = "EQUILATERO";
            }
            else if (A == B || B == C || C == A)
            {
                triangulo = "ISOSCELES";
            }

            if (triangulo != "")
            {
                Console.WriteLine("TRIANGULO {0}", triangulo);
            }
        }
    }
}