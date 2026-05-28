internal class Program
{
    private static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());

        for (int i = 1; i <= T; i++)
        {
            string[] jogada = Console.ReadLine().Split(' ');

            string sheldon = jogada[0];
            string raj = jogada[1];

            string R = "";

            int resultado = 0;

            if (sheldon == raj)
                resultado = 3;
            else
            {
                switch (sheldon)
                {
                    case "tesoura":

                        if (raj == "papel" || raj == "lagarto")
                            resultado = 1;
                        else resultado = 2;

                        break;
                    case "papel":

                        if (raj == "pedra" || raj == "Spock")
                            resultado = 1;
                        else resultado = 2;

                        break;
                    case "pedra":

                        if (raj == "tesoura" || raj == "lagarto")
                            resultado = 1;
                        else resultado = 2;

                        break;
                    case "lagarto":

                        if (raj == "Spock" || raj == "papel")
                            resultado = 1;
                        else resultado = 2;

                        break;
                    case "Spock":

                        if (raj == "tesoura" || raj == "pedra")
                            resultado = 1;
                        else resultado = 2;

                        break;
                }
            }

            switch (resultado)
            {
                case 1:
                    R = "Bazinga";
                    break;
                case 2:
                    R = "Raj trapaceou";
                    break;
                case 3:
                    R = "De novo";
                    break;
                default:
                    break;
            }

            Console.WriteLine($"Caso #{i}: {R}!");
        }
    }
}