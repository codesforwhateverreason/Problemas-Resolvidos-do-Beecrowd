internal class Program
{
    private static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        string[] SD = new string[N];
        string[] SN = new string[N];

        for (int i = 0; i < N; i++)
        {
            string[] entradas = Console.ReadLine().Split(' ');

            SD[i] = entradas[0];
            SN[i] = entradas[1];
        }

        int C = 0, E = 0;
        int guardachuvas_emcasa = 0, guardachuvas_noescritorio = 0;

        for (int i = 0; i < SD.Length; i++)
        {
            if (SD[i] == "chuva")
            {
                if (guardachuvas_emcasa == 0)
                    C++;

                if (SN[i] == "chuva")
                    guardachuvas_emcasa += (guardachuvas_emcasa + guardachuvas_noescritorio < C + E) ? 1 : 0;
                else
                {
                    guardachuvas_noescritorio++;
                    guardachuvas_emcasa -= (guardachuvas_emcasa - 1 < 0) ? 0 : 1;
                }
            }
            else if (SN[i] == "chuva")
            {
                if (guardachuvas_noescritorio == 0)
                    E++;

                guardachuvas_emcasa++;
                guardachuvas_noescritorio -= (guardachuvas_noescritorio - 1 < 0) ? 0 : 1;
            }      
        }

        Console.WriteLine($"{C} {E}");
    }
}