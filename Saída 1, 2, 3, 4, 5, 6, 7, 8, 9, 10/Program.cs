internal class Program
{
    private static void Main(string[] args)
    {
    }

    static void Saida1()
    {
        Console.WriteLine(new string('-', 39));

        Console.WriteLine('|' + new string(' ', 37) + '|');
        Console.WriteLine('|' + new string(' ', 37) + '|');
        Console.WriteLine('|' + new string(' ', 37) + '|');
        Console.WriteLine('|' + new string(' ', 37) + '|');
        Console.WriteLine('|' + new string(' ', 37) + '|');

        Console.WriteLine(new string('-', 39));
    }

    static void Saida2()
    {
        Console.WriteLine(new string('-', 39));

        Console.WriteLine('|' + new string(' ', 8) + "Roberto" + new string(' ', 22) + '|');
        Console.WriteLine('|' + new string(' ', 37) + '|');
        Console.WriteLine('|' + new string(' ', 8) + "5786" + new string(' ', 25) + '|');
        Console.WriteLine('|' + new string(' ', 37) + '|');
        Console.WriteLine('|' + new string(' ', 8) + "UNIFEI" + new string(' ', 23) + '|');

        Console.WriteLine(new string('-', 39));
    }

    static void Saida3()
    {
        Console.WriteLine(new string('-', 39));

        Console.WriteLine('|' + "x = 35" + new string(' ', 31) + '|');
        Console.WriteLine('|' + new string(' ', 37) + '|');
        Console.WriteLine('|' + new string(' ', 15) + "x = 35" + new string(' ', 16) + '|');
        Console.WriteLine('|' + new string(' ', 37) + '|');
        Console.WriteLine('|' + new string(' ', 31) + "x = 35" + '|');

        Console.WriteLine(new string('-', 39));
    }

    static void Saida4()
    {
        Console.WriteLine(new string('-', 39));
        Console.WriteLine('|' + "  decimal  " + '|' +  "  octal  " + '|' + "  Hexadecimal  " + '|');
        Console.WriteLine(new string('-', 39));

        for (int i = 0; i < 16; i++)
            Console.WriteLine('|' + $"{i}".PadLeft(7) + "|".PadLeft(5) + $"{Convert.ToString(i, 8)}".PadLeft(5) + "|".PadLeft(5) + $"{Convert.ToString(i, 16).ToUpper()}".PadLeft(8) + "|".PadLeft(8));

        Console.WriteLine(new string('-', 39));
    }

    static void Saida6()
    {
        string frase = "AMO FAZER EXERCICIO NO URI";

        Console.WriteLine("<" + frase + ">");
        Console.WriteLine("<" + $"{frase, 30}" + ">");
        Console.WriteLine("<" + $"{frase.Substring(0, 20)}" + ">");
        Console.WriteLine("<" + $"{frase, -20}" + ">");
        Console.WriteLine("<" + $"{frase, -30}" + ">");
        Console.WriteLine("<" + $"{((frase.Length > 30) ? frase.Substring(0, 30) : frase)}" + ">");
        Console.WriteLine("<" + $"{frase.Substring(0, 20), 30}" + ">");
        Console.WriteLine("<" + $"{frase.Substring(0, 20), -30}" + ">");
    }

    static void Saida7()
    {
        for (int i = 97; i < 123; i++)
            Console.WriteLine($"{i} e {(char)i}");
    }

    static void Saida8()
    {
        double a = 234.345, b = 45.698;

        Console.WriteLine($"{a:F6} - {b:F6}");
        Console.WriteLine($"{a:F0} - {b:F0}");
        Console.WriteLine($"{a:F1} - {b:F1}");
        Console.WriteLine($"{a:F2} - {b:F2}");
        Console.WriteLine($"{a:F3} - {b:F3}");
        Console.WriteLine($"{a:e} - {b:e}");
        Console.WriteLine($"{a:E} - {b:E}");
        Console.WriteLine(($"{a:E}".Length > a.ToString().Length && $"{b:E}".Length > b.ToString().Length) ? $"{a:E} - {b:E}" : $"{a} - {b}");
        Console.WriteLine(($"{a:E}".Length > a.ToString().Length && $"{b:E}".Length > b.ToString().Length) ? $"{a:E} - {b:E}" : $"{a} - {b}");
    }

    static void Saida9()
    {
        Console.WriteLine("\"Ro\'b\'er\tto\\/\"");
        Console.WriteLine("(._.) ( l: ) ( .-. ) ( :l ) (._.)");
        Console.WriteLine("(^_-) (-_-) (-_^)");
        Console.WriteLine("(\"_\") (\'.\')");
    }

    static void Saida10()
    {
        Console.WriteLine("A".PadLeft(8));
        Console.WriteLine("B".PadLeft(7) + "B".PadLeft(2));
        Console.WriteLine("C".PadLeft(6) + "C".PadLeft(4));
        Console.WriteLine("D".PadLeft(5) + "D".PadLeft(6));
        Console.WriteLine("E".PadLeft(4) + "E".PadLeft(8));
        Console.WriteLine("D".PadLeft(5) + "D".PadLeft(6));
        Console.WriteLine("C".PadLeft(6) + "C".PadLeft(4));
        Console.WriteLine("B".PadLeft(7) + "B".PadLeft(2));
        Console.WriteLine("A".PadLeft(8));
    }
}