internal class Program
{
    private static void Main(string[] args)
    {
        string entradas;

        while((entradas = Console.ReadLine()) != null)
        {
            string[] jogadas = entradas.Split(' ');

            string[] jogadores = {"Dodo", "Leo", "Pepper"};

            int vitorias = 0;
            string vencedor = "";

            for (int i = 0; i < jogadas.Length; i++)
            {
                switch(jogadas[i])
                {
                    case "pedra":
                        for(int j = 1; j < jogadas.Length; j++)
                        {
                            if (jogadas[(i + j) % jogadas.Length] == "tesoura")
                            {
                                vitorias++;
                                vencedor = jogadores[i];
                                break;
                            }
                        }
                        break;

                    case "papel":
                        for (int j = 1; j < jogadas.Length; j++)
                        {
                            if (jogadas[(i + j) % jogadas.Length] == "pedra")
                            {
                                vitorias++;
                                vencedor = jogadores[i];
                                break;
                            }
                        }
                        break;

                    case "tesoura":
                        for (int j = 1; j < jogadas.Length; j++)
                        {
                            if (jogadas[(i + j) % jogadas.Length] == "papel")
                            {
                                vitorias++;
                                vencedor = jogadores[i];
                                break;
                            }
                        }
                        break;
                }
            }


            if (vitorias != 1)
                Console.WriteLine("Putz vei, o Leo ta demorando muito pra jogar...");
            else
            {
                switch(vencedor)
                {
                    case "Dodo":
                        Console.WriteLine("Os atributos dos monstros vao ser inteligencia, sabedoria...");
                        break;

                    case "Leo":
                        Console.WriteLine("Iron Maiden's gonna get you, no matter how far!");
                        break;

                    case "Pepper":
                        Console.WriteLine("Urano perdeu algo muito precioso...");
                        break;
                }
            }

        }
    }
}