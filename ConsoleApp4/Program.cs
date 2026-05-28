internal class Program
{
    private static void Main(string[] args)
    {
        string entradas = Console.ReadLine();

        string[] numeros = entradas.Split(' ');

        int hi = int.Parse(numeros[0]);
        int mi = int.Parse(numeros[1]);
        int hf = int.Parse(numeros[2]);
        int mf = int.Parse(numeros[3]);

        string horas = "", minutos = "";

        int dh = 0, dm = 0;

        if (hi == hf)
        {
            if (mi == mf)
            {
                dh = 24;
            }
            else if (mi > mf)
            {
                dh = 23;
                dm = 60 - (mi - mf);
            }
            else
            {
                dm = mf - mi;
            }
        } else
        {
            if (hi > hf)
            {
                dh = 24 - (hi - hf);
            } else
            {
                dh = hf - hi;
            }

            if (mi > mf)
            {
                dh--;
                dm = 60 - (mi - mf);
            }
            else if (mi < mf)
            {
                dm = mf - mi;
            }
        }

        horas = dh.ToString();
        minutos = dm.ToString();

        Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", horas, minutos);
    }
}