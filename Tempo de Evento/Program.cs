internal class Program
{
    private static void Main(string[] args)
    {
        int[] dias = new int[2];
        int[] horas = new int[3];
        int[] minutos = new int[3];
        int[] segundos = new int[3];

        string[] tempo;

        string entradas;

        Console.Write("Dia ");
        dias[0] = int.Parse(Console.ReadLine());

        entradas = Console.ReadLine();

        tempo = entradas.Split(" : ");

        horas[0] = int.Parse(tempo[0]);
        minutos[0] = int.Parse(tempo[1]);
        segundos[0] = int.Parse(tempo[2]);

        Console.Write("Dia ");
        dias[1] = int.Parse(Console.ReadLine());

        entradas = Console.ReadLine();

        tempo = entradas.Split(" : ");

        horas[1] = int.Parse(tempo[0]);
        minutos[1] = int.Parse(tempo[1]);
        segundos[1] = int.Parse(tempo[2]);

        int difd = dias[1] - dias[0], difh = 0, difm = 0, difs = 0;

        if (horas[0] > horas[1] || (horas[0] == horas[1] && minutos[0] > minutos[1]) || (horas[0] == horas[1] && segundos[0] > segundos[1]))
        {
            difh = 24 - (horas[0] - horas[1]);
        }
        else if (horas[0] < horas[1])
        {
            difh = horas[1] - horas[0];
        }

        if (minutos[0] > minutos[1])
        {
            difh--;
            difm = 60 - (minutos[0] - minutos[1]);
        }
        else if (minutos[0] < minutos[1])
        {
            difm = minutos[1] - minutos[0];
        }

        if (segundos[0] > segundos[1])
        {
            difm--;
            difs = 60 - (segundos[0] - segundos[1]);
        }
        else if (segundos[0] < segundos[1])
        {
            difs = segundos[1] - segundos[0];
        }

        if (horas[0] > horas[1] || minutos[0] > minutos[1] || segundos[0] > segundos[1])
        {
            difd--;
        }

        Console.WriteLine("{0} dia(s)", difd);
        Console.WriteLine("{0} hora(s)", difh);
        Console.WriteLine("{0} minuto(s)", difm);
        Console.WriteLine("{0} segundo(s)", difs);
    }
}