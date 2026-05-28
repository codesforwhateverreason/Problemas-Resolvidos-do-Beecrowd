using System.Net.Http.Headers;
using System.Runtime.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        while(true)
        {
            string entrada = Console.ReadLine();

            if (String.IsNullOrEmpty(entrada))
                break;

            string[] tempo = entrada.Split(' ');

            int H = int.Parse(tempo[0]);
            int M = int.Parse(tempo[1]);

            string[] medidas = Console.ReadLine().Split(' ');

            double[] Xi = Array.ConvertAll(medidas, double.Parse);

            double soma = 0;

            foreach (double num in Xi)
                soma += num;

            int quantidade = (int)Math.Floor((double)(H * 60) / M);

            double media = soma / quantidade;

            double somatoria = 0;

            foreach (double num in Xi)
                somatoria += Math.Pow((num - media), 2);

            double resultado = Math.Sqrt(somatoria / (quantidade - 1));

            Console.WriteLine("{0:f5}", resultado);
        }
    }
}