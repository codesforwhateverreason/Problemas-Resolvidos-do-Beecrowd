using Microsoft.VisualBasic;

internal class Program
{
    private static void Main(string[] args)
    {
        EntradaeSaidaLendoePulandoNomes();
    }

    static void EntradaeSaídadeNúmerosInteiros()
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());

        Console.WriteLine($"A = {A}, B = {B}, C = {C}");
        Console.WriteLine($"A = {A, 10}, B = {B, 10}, C = {C, 10}");
        Console.WriteLine($"A = {A.ToString("0000000000;-000000000")}, B = {B.ToString("0000000000; -000000000")}, C = {C.ToString("0000000000; -000000000")}");
        Console.WriteLine($"A = {A, -10}, B = {B, -10}, C = {C, -10}");
    }

    static void EntradaeSaídadeNúmerosReais()
    {
        string[] entrada = Console.ReadLine().Split(' ');

        float A = float.Parse(entrada[0]), B = float.Parse(entrada[1]);

        entrada = Console.ReadLine().Split(' ');

        double C = double.Parse(entrada[0]), D = double.Parse(entrada[1]);

        Console.WriteLine($"A = {A:F6}, B = {B:F6}");
        Console.WriteLine($"C = {C:F6}, D = {D:F6}");
        Console.WriteLine($"A = {A:F1}, B = {B:F1}");
        Console.WriteLine($"C = {C:F1}, D = {D:F1}");
        Console.WriteLine($"A = {A:F2}, B = {B:F2}");
        Console.WriteLine($"C = {C:F2}, D = {D:F2}");
        Console.WriteLine($"A = {A:F3}, B = {B:F3}");
        Console.WriteLine($"C = {C:F3}, D = {D:F3}");

        /*
        //Certa pro C#
        Console.WriteLine($"A = {A:E3}, B = {B:E3}");
        Console.WriteLine($"C = {C:E3}, D = {D:E3}");
        */

        Console.WriteLine($"A = {A:0.000E+00}, B = {B:0.000E+00}");
        Console.WriteLine($"C = {C:0.000E+00}, D = {D:0.000E+00}");
        Console.WriteLine($"A = {A:F0}, B = {B:F0}");
        Console.WriteLine($"C = {C:F0}, D = {D:F0}");
    }

    static void EntradaeSaidadeCaracter()
    {
        char[] caracteres = new char[3];

        for (int i = 0; i < 3; i++)
            caracteres[i] = char.Parse(Console.ReadLine());

        for (int i = 0; i < 3; i++)
            Console.WriteLine($"A = {caracteres[i]}, B = {caracteres[(i + 1) % 3]}, C = {caracteres[(i + 2) % 3]}");
    }

    static void EntradaeSaidadeString()
    {
        string[] palavras = new string[3];

        for (int i = 0; i < 3; i++)
            palavras[i] = Console.ReadLine();

        for (int i = 0; i < 3; i++)
            Console.WriteLine($"{palavras[i]}{palavras[(i + 1) % 3]}{palavras[(i + 2) % 3]}");

        for (int i = 0; i < 3; i++)
        {
            if (palavras[i].Length >= 10)
                Console.Write($"{palavras[i][..10]}"); // Range (Mostrar até certa parte da string)
            else Console.Write($"{palavras[i]}");
        }
        Console.WriteLine();
    }

    static void EntradaeSaidadeVariosTipos()
    {
        // Separa as entradas em até 4 partes (Quando encontra um espaço já determina a parte antes do separador com uma das partes)
        string[] entradas = Console.ReadLine().Split(null, 4); 

        int A = int.Parse(entradas[0]);
        float B = float.Parse(entradas[1]);
        char C = char.Parse(entradas[2]);
        string D = entradas[3];

        Console.WriteLine($"{A}{B:F6}{C}{D}");
        Console.WriteLine($"{A}\t{B:F6}\t{C}\t{D}");
        Console.WriteLine($"{A}".PadLeft(10) + $"{B:F6}".PadLeft(10) + $"{C}".PadLeft(10) + $"{D}".PadLeft(10));
    }

    static void EntradaeSaida6()
    {
        decimal A = decimal.Parse(Console.ReadLine());

        decimal casasDecimais = (A - Math.Truncate(A)) * 1000;

        while (casasDecimais % 10 == 0)
            casasDecimais /= 10;
        

        Console.WriteLine($"{(int)casasDecimais}.{Math.Truncate(A)}"); // Escrever desse jeito
        Console.WriteLine($"{(int)casasDecimais + (Math.Truncate(A) / (decimal)Math.Pow(10, Math.Truncate(A).ToString().Length))}"); // Ou desse jeito
    }

    static void EntradaeSaidaCPF()
    {
        string[] CPF = Console.ReadLine().Split('.', '-');

        foreach (string i in CPF)
            Console.WriteLine(i);
    }
    static void EntradaeSaidadeData()
    {
        int[] info = Console.ReadLine().Split('/').Select(int.Parse).ToArray();

        DateTime data = new DateTime(info[^1], info[^2], info[^3]);

        Console.WriteLine($"{data:MM/dd/yy}");
        Console.WriteLine($"{data:yy/MM/dd}");
        Console.WriteLine($"{data:dd-MM-yy}");
    }

    static void EntradaeSaidacomVirgula()
    {
        string[] texto = Console.ReadLine().Split(',');

        Console.WriteLine(texto[0]);
        Console.WriteLine(texto[1]);
    }
    static void EntradaeSaidaLendoePulandoNomes()
    {
        string[] nomes = new string[10];

        for (int i = 0; i < 10; i++)
            nomes[i] = Console.ReadLine();

        Console.WriteLine(nomes[2]);
        Console.WriteLine(nomes[6]);
        Console.WriteLine(nomes[8]);
    }
}