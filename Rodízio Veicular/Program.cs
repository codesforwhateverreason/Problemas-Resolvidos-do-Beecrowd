internal class Program
{
    private static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            string placa = Console.ReadLine();

            string[] partes = (placa.Contains('-')) ? placa.Split('-') : null;

            string dia = "";

            if (partes != null)
            {
                string letras = partes[0];
                string numeros = partes[1];

                if (letras.Length + numeros.Length == 7 && letras.All(l => char.IsUpper(l) && char.IsLetter(l)) && numeros.All(n => char.IsDigit(n)))
                {

                    char ultimodigito = numeros[^1];


                    switch (ultimodigito)
                    {
                        case '1':
                        case '2':
                            dia = "MONDAY";
                            break;

                        case '3':
                        case '4':
                            dia = "TUESDAY";
                            break;

                        case '5':
                        case '6':
                            dia = "WEDNESDAY";
                            break;

                        case '7':
                        case '8':
                            dia = "THURSDAY";
                            break;

                        case '9':
                        case '0':
                            dia = "FRIDAY";
                            break;
                    }
                } else dia = "FAILURE";
            } else dia = "FAILURE";

            Console.WriteLine(dia);
        }
    }
}