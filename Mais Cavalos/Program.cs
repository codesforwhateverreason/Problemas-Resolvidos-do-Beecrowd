internal class Program
{
    private static void Main(string[] args)
    {
        string[] posicoes = Console.ReadLine().Split(' ');

        string posicaoinicial = posicoes[0];
        string posicaofinal = posicoes[1];

        if ((Math.Abs(posicaoinicial[0] - posicaofinal[0]) == 2 && Math.Abs(posicaoinicial[1] - posicaofinal[1]) == 1) ||   // Meu Deus, como é estranho dividir if assim.
            (Math.Abs(posicaoinicial[0] - posicaofinal[0]) == 1 && Math.Abs(posicaoinicial[1] - posicaofinal[1]) == 2))     // A subtração ocorre entre os valores ascii dos caracteres, o que não muda muito na lógica.
            Console.WriteLine("VALIDO");
        else Console.WriteLine("INVALIDO");

    }
}