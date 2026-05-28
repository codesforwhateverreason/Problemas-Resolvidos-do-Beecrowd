
internal class Program
{
    private static void Main(string[] args)
    {
        string[] entradas = Console.ReadLine().Split(' ');

        int A = int.Parse(entradas[0]);
        int B = int.Parse(entradas[1]);
        int C = int.Parse(entradas[2]);

        bool possivel = false;

        if (A == 0 || B == 0 || C == 0)
            possivel = true;
        else if (A - B == 0 || A - C == 0 || B - C == 0)
            possivel = true;
        else if (A + B - C == 0 || A - B + C == 0 || A - B - C == 0)
            possivel = true;

        Console.WriteLine(possivel ? "S" : "N");
    }
}