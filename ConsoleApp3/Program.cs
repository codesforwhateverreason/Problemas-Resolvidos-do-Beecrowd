internal class Program
{
    private static void Main(string[] args)
    {
        string entradas = Console.ReadLine();

        string[] numeros = entradas.Split(' ');

        float n1 = float.Parse(numeros[0]);
        float n2 = float.Parse(numeros[1]);
        float n3 = float.Parse(numeros[2]);
        float n4 = float.Parse(numeros[3]);

        float media = ((n1 * 2) + (n2 * 3) + (n3 * 4) + n4) / 10;

        string situacao = "";

        float notaexame;

        if (media >= 7)
            situacao = "aprovado";
        else if (media < 5)
            situacao = "reprovado";
        else situacao = "em exame";

        media = Convert.ToSingle(Math.Truncate(media * 10) / 10f);

        Console.WriteLine("Media: {0:f1}", media);
        Console.WriteLine("Aluno {0}.", situacao);

        if (situacao == "em exame")
        {
            notaexame = float.Parse(Console.ReadLine());
            media = (media + notaexame) / 2;

            if (media >= 5)
                situacao = "aprovado";
            else situacao = "reprovado";

            Console.WriteLine("Nota do exame: {0:f1}", notaexame);
            Console.WriteLine("Aluno {0}.", situacao);
            Console.WriteLine("Media final: {0:f1}", media);
        }
    }
}