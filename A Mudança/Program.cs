internal class Program
{
    private static void Main(string[] args)
    {
        // A Mudança
        /*
        string[] mensagens = { "Bom Dia", "Boa Tarde", "Boa Noite", "De Madrugada"};

        while ((int.TryParse(Console.ReadLine(), out int M)))
        {
            int indice = (int)((M / 90f) % 4);
            Console.WriteLine($"{mensagens[indice]}!!");
        }
        */

        //A Mudança Continua!!
        string[] mensagens = { "Bom Dia", "Boa Tarde", "Boa Noite", "De Madrugada" };

        while ((double.TryParse(Console.ReadLine(), out double M)))
        {
            int indice = (int)((M / 90f) % 4);
            Console.WriteLine($"{mensagens[indice]}!!");

            int segundos = (int)(M * 240);

            int horas = ((segundos / 3600) + 6) % 24;
            segundos %= 3600;
            int minutos = (segundos / 60);
            segundos %= 60;

            Console.WriteLine($"{horas:D2}:{minutos:D2}:{segundos:D2}");

        }
    }
}