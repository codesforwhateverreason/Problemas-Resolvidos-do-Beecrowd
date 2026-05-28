internal class Program
{
    private static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());

        for (int i = 0; i < T; i++)
        {
            string[] entradas = Console.ReadLine().Split(' ');

            int w = int.Parse(entradas[0]);
            int h = int.Parse(entradas[1]);
            int x0 = int.Parse(entradas[2]);
            int y0 = int.Parse(entradas[3]);

            entradas = Console.ReadLine().Split(' ');

            string magia = entradas[0];
            int nivel = int.Parse(entradas[1]);
            int cx = int.Parse(entradas[2]);
            int cy = int.Parse(entradas[3]);

            int[] fogo = {20, 30, 50};
            int[] agua = {10, 25, 40};
            int[] terra = {25, 55, 70};
            int[] ar = {18, 38, 60};

            int dano = 0, raio = 0;

            switch (magia)
            {
                case "fire":
                    raio = fogo[nivel - 1];
                    dano = 200;
                    break;

                case "water":
                    raio = agua[nivel - 1];
                    dano = 300;
                    break;

                case "earth":
                    raio = terra[nivel - 1];
                    dano = 400;
                    break;

                case "air":
                    raio = ar[nivel - 1];
                    dano = 100;
                    break;
            }

            int xProximo = Math.Max(x0, Math.Min(cx, x0 + w));
            int yProximo = Math.Max(y0, Math.Min(cy, y0 + h));

            if (Math.Pow(cx - xProximo, 2) + Math.Pow(cy - yProximo, 2) <= raio * raio)
                Console.WriteLine(dano);
            else Console.WriteLine(0);
        }
    }
}