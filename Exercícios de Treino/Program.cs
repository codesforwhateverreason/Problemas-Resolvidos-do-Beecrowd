using System.ComponentModel.Design;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Security.AccessControl;

internal class Program
{
    private static void Main(string[] args)
    {
        int opcao = 0;
        do
        {
            opcao = menu();

            Console.WriteLine();

            switch (opcao)
            {
                case 0:
                    Console.WriteLine("F I M");
                    break;
                case 1:
                    soma();
                    break;
                case 2:
                    conversor();
                    break;
                case 3:
                    idadevoto();
                    break;
                case 4:
                    comparador();
                    break;
                case 5:
                    seguros();
                    break;
                case 6:
                    horasextras();
                    break;
                case 7:
                    variascontas();
                    break;
                case 8:
                    calculadorasimples();
                    break;
                case 9:
                    contagemregressiva();
                    break;
                case 10:
                    adivinhar();
                    break;
                case 11:
                    calculadoracontinua();
                    break;
                case 12:
                    somapares();
                    break;
                case 13:
                    desenhotriangulo();
                    break;
                case 14:
                    listacompras();
                    break;
                case 15:
                    triangulo2();
                    break;
                default:
                    Console.WriteLine("\nOpção Inválida");
                    break;
            }
        }
        while (opcao != 0);
    }

    public static int menu()
    {
        int opcao = 0;
        Console.WriteLine("\nM E N U");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Conversor");
        Console.WriteLine("3 - Verificação de idade para votar");
        Console.WriteLine("4 - Comparador de números");
        Console.WriteLine("5 - Verificador de grupo de risco");
        Console.WriteLine("6 - Verificador de prêmio");
        Console.WriteLine("7 - Várias Contas");
        Console.WriteLine("8 - Calculadora Simples");
        Console.WriteLine("9 - Contagem Regressiva");
        Console.WriteLine("10 - Adivinhar o número");
        Console.WriteLine("11 - Calculadora Contínua");
        Console.WriteLine("12 - Soma dos números pares");
        Console.WriteLine("13 - Desenho de Triângulo");
        Console.WriteLine("14 - Lista de Compras");
        Console.WriteLine("15 - Triângulo Diferenciado");
        Console.WriteLine("0 - Sair");
        opcao = int.Parse(Console.ReadLine());
        return opcao;
    }

    public static void soma()
    {
        int a = 0;
        int b = 0;

        Console.WriteLine("Valor de a: ");
        a = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Valor de b: ");
        b = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("A soma de {0} e {1} é {2}", a, b, a + b);
    }

    public static void conversor()
    {
        double valorReais, taxaDolar;
        Console.WriteLine("Valor reais: ");
        valorReais = double.Parse(Console.ReadLine());

        Console.WriteLine("Taxa dólar: ");
        taxaDolar = double.Parse(Console.ReadLine());

        Console.WriteLine("{0:C} reais são iguais a {1:N} dólares", valorReais, valorReais / taxaDolar);
    }

    public static void idadevoto()
    {
        int idade;
        Console.WriteLine("Qual a sua idade?");
        idade = int.Parse(Console.ReadLine());

        if (idade >= 16)
        {
            Console.WriteLine("Você pode votar");
        }
        else
        {
            Console.WriteLine("Você ainda não pode votar.");
        }
    }

    public static void comparador()
    {
        int a, b;
        Console.WriteLine("Valor de a:");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Valor de b:");
        b = int.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine("{0} é maior que {1}", a, b);
        }
        else if (a < b)
        {
            Console.WriteLine("{0} é maior que {1}", b, a);
        }
        else
        {
            Console.WriteLine("Os números são iguais");
        }
    }

    public static void seguros()
    {
        int idade, numero = 0;
        char grupo;

        Console.WriteLine("Qual a sua idade?");
        idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Qual o seu grupo de risco?");
        grupo = char.Parse(Console.ReadLine());

        if ((idade >= 18) && (idade <= 24))
        {
            switch (grupo)
            {
                case 'b':
                    numero = 7;
                    break;
                case 'm':
                    numero = 8;
                    break;
                case 'a':
                    numero = 9;
                    break;
                default:
                    Console.WriteLine("Categoria Inválida");
                    break;
            }
        }
        else if ((idade >= 25) && (idade <= 40))
        {
            switch (grupo)
            {
                case 'b':
                    numero = 4;
                    break;
                case 'm':
                    numero = 5;
                    break;
                case 'a':
                    numero = 6;
                    break;
                default:
                    Console.WriteLine("Categoria Inválida");
                    break;
            }
        }
        else if ((idade >= 41) && (idade <= 70))
        {
            switch (grupo)
            {
                case 'b':
                    numero = 1;
                    break;
                case 'm':
                    numero = 2;
                    break;
                case 'a':
                    numero = 3;
                    break;
                default:
                    Console.WriteLine("Categoria Inválida");
                    break;
            }
        }
        Console.WriteLine("Seu grupo de risco é: {0}", numero);
    }

    public static void horasextras()
    {
        double H = 0;
        float extras, faltas;
        int premio = 500;

        Console.WriteLine("Quantas horas extras você trabalhou? (em minutos)");
        extras = float.Parse(Console.ReadLine());

        Console.WriteLine("Quantas horas você faltou no trabalho? (em minutos)");
        faltas = float.Parse(Console.ReadLine());

        H = extras - ((2 * faltas) / 3);

        if ((H <= 2400) && (H > 1800))
        {
            premio = 400;
        }
        else if ((H <= 1800) && (H > 1200))
        {
            premio = 300;
        }
        else if ((H <= 1200) && (H > 600))
        {
            premio = 200;
        }
        else if (H <= 600)
        {
            premio = 100;
        }
        Console.WriteLine("Horas extras: {0}\nHoras-Faltas: {1}\nPrêmio: {2:C}", extras / 60, faltas / 60, premio);
    }

    public static void variascontas()
    {
        int quantidade, pares = 0, impares = 0;
        double soma = 0;

        Console.WriteLine("Quantos números você irá digitar?");
        quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine();

        double[] numeros = new double[quantidade];

        for (int i = 0; i < quantidade; i++)
        {
            numeros[i] = double.Parse(Console.ReadLine());
            soma += numeros[i];

            if (numeros[i] % 2 == 0)
            {
                pares++;
            } else
            {
                impares++;
            }
        }

        Console.WriteLine();

        Console.WriteLine("O maior número é: {0}", numeros.Max()); 
        Console.WriteLine("O menor número é: {0}", numeros.Min());
        Console.WriteLine("A soma dos números é: {0}", soma);
        Console.WriteLine("A média dos números é: {0}", soma / quantidade);
        Console.WriteLine("O total de números pares é: {0}", pares);
        Console.WriteLine("O total de números ímpares é: {0}", impares);
        Console.WriteLine("A quantidade de números entrados é: {0}", quantidade);
    }

    public static void calculadorasimples()
    {
        double num1, num2;
        int escolha;

        Console.WriteLine("Escolha uma operação:\n1 - Adição\n2 - Subtração\n3 - Multiplicação\n4 - Divisão");
        escolha = int.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("Qual é o primeiro número?");
        num1 = double.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("Qual é o segundo número?");
        num2 = double.Parse(Console.ReadLine());

        Console.WriteLine();

        switch (escolha)
        {
            case 1:
                Console.WriteLine("A soma dos números é: {0}", num1 + num2);
                break;
            case 2:
                Console.WriteLine("A subtração dos números é: {0}", num1 - num2);
                break;
            case 3:
                Console.WriteLine("O produto dos números é: {0}", num1 * num2);
                break;
            case 4:
                if (num2 != 0)
                {
                    Console.WriteLine("O quociente dos números é: {0}", num1 / num2);
                }
                else Console.WriteLine("Não é possível dividir por zero");
                break;
            default: 
                Console.WriteLine("Operação Inválida");
                break;
        }

    }

    public static void contagemregressiva()
    {
        int numero;

        Console.WriteLine("Digite um número");
        numero = int.Parse(Console.ReadLine());

        Console.WriteLine();

        while(numero >= 0)
        {
            Console.WriteLine(numero);
            numero--;
        }
    }

    public static void adivinhar()
    {
        Random aleatorio = new Random();
        int numeroaleatorio = aleatorio.Next(1, 101);

        int palpite;

        do
        {
            Console.WriteLine("Adivinhe o número");
            palpite = int.Parse(Console.ReadLine());

            if (palpite < numeroaleatorio)
            {
                Console.WriteLine("O número é maior\n");
            }
            else if (palpite > numeroaleatorio)
            {
                Console.WriteLine("O número é menor\n");
            }
        } while (palpite != numeroaleatorio);

        Console.WriteLine("Parabéns! Você adivinhou o número");
        Console.WriteLine("Vugnaes Sreo! :P\n");
    }

    public static void calculadoracontinua()
    {
        double num1, num2;
        int escolha;

        do
        {
            Console.WriteLine("Escolha uma operação:\n1 - Adição\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n0 - Sair");
            escolha = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (escolha != 0)
            {
                Console.WriteLine("Qual é o primeiro número?");
                num1 = double.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Qual é o segundo número?");
                num2 = double.Parse(Console.ReadLine());

                Console.WriteLine();

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("A soma dos números é: {0}\n", num1 + num2);
                        break;
                    case 2:
                        Console.WriteLine("A subtração dos números é: {0}\n", num1 - num2);
                        break;
                    case 3:
                        Console.WriteLine("O produto dos números é: {0}\n", num1 * num2);
                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            Console.WriteLine("O quociente dos números é: {0}\n", num1 / num2);
                        }
                        else Console.WriteLine("Não é possível dividir por zero\n");
                        break;
                    default:
                        Console.WriteLine("Operação Inválida\n");
                        break;
                }
            } else break;
        } while (escolha != 0);

        Console.WriteLine("Tchau!\n");
    }        

    public static void somapares()
    {
        int numero, soma = 0;

        Console.WriteLine("Qual o número máximo?");
        numero = int.Parse(Console.ReadLine());

        Console.WriteLine();

        for(int i = 1; i <= numero; i++)
        {
            if (i % 2 == 0)
            {
                soma += i;
            }
        }

        Console.WriteLine("A soma dos números pares de 1 até {0} é: {1}", numero, soma);
    }

    public static void desenhotriangulo()
    {
        int altura;

        Console.WriteLine("Qual será altura do triângulo?");
        altura = int.Parse(Console.ReadLine());

        Console.WriteLine();

        for (int i = 1; i <= altura; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }
    }

    public static void listacompras()
    {
        int itens;

        Console.WriteLine("Quantos itens quer adicionar à lista?");
        itens = int.Parse(Console.ReadLine());

        string[] compras = new string[itens];

        Console.WriteLine();

        for (int i = 0; i < itens; i++)
        {
            Console.WriteLine("Item {0}", i+1);
            compras[i] = Console.ReadLine();
            Console.WriteLine();
        }

        Console.WriteLine("Itens da lista de compras:");
        for (int i = 0; i < itens; i++)
        {
            Console.WriteLine(compras[i]);
        }
    }

    public static void triangulo2()
    {
        for (int i = 1; i <= 20; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                if (i % 2 == 0)
                {
                    Console.Write('-');
                }
                else
                {
                    Console.Write('*');
                }     
            }
            Console.WriteLine();
        }
    }
}