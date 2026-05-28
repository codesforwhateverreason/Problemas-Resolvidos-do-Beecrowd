using Controle_de_Gastos_com_Classes;
using System.Security.AccessControl;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        //Gasto mercado = new Gasto("Mercado", 100, 9, 2025);
        //Console.WriteLine(mercado);

        ControleDeGastos despesas = new ControleDeGastos();

        /*
        despesas.AdicionarGasto(mercado);
        despesas.AdicionarGasto(new Gasto("farmacia", 200, 7, 2025));
        despesas.AdicionarGasto(new Gasto("padaria", 400, 8, 2024));
        despesas.AdicionarGasto(new Gasto("shopping", 600, 9, 2023));

        foreach(Gasto gasto in despesas.gastos)
        {
            Console.WriteLine(gasto);
        }
        */

        int opcao, indice;

        do
        {
            opcao = ExibirMenu();
            Console.WriteLine();
            switch (opcao)
            {
                case 0:
                    break;
                case 1:
                    despesas.AdicionarGasto(entradaDados());
                    break;
                case 2:
                    despesas.ListarGastos();
                    break;
                case 3:
                    Console.WriteLine("Total de gastos  {0:C}", despesas.CalcularTotal());
                    break;
                case 4:
                    int mes = 0, ano = 0;
                    entradaDadosMesAno(ref mes, ref ano);
                    despesas.ListarPorMesAno(mes, ano);
                    break;
                case 5:
                    if (despesas.gastos.Count > 0)
                    {
                        Console.WriteLine("Qual despesa deseja editar? (Digite o índice)");
                        indice = int.Parse(Console.ReadLine());
                        despesas.EditarGasto(indice - 1);
                    }
                    else Console.WriteLine("Não há despesas");
                    break;
                case 6:
                    if (despesas.gastos.Count > 0)
                    {
                        Console.WriteLine("Qual despesa deseja retirar? (Digite o índice)");
                        indice = int.Parse(Console.ReadLine());
                        despesas.RemoverGasto(indice - 1);
                    }
                    else Console.WriteLine("Não há despesas");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
            Console.WriteLine();
        }
        while (opcao != 0);
    }

    public static Gasto entradaDados()
    {
        string descricao;
        decimal valor;
        int mes, ano;

        Console.WriteLine("Descrição: ");
        descricao = Console.ReadLine();

        Console.WriteLine("Valor: ");
        valor = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Mês: ");
        mes = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Ano: ");
        ano = Convert.ToInt16(Console.ReadLine());


        Gasto gasto = new Gasto(descricao, valor, mes, ano);

        return gasto;
    }


    public static int ExibirMenu()
    {
        int opcao;

        Console.WriteLine("Menu:\n1 - Adicionar gastos\n2 - Listar gastos\n3 - Calcular total do gasto\n4 - Gasto de tempo específico\n5 - Editar gasto\n6 - Retirar gasto\n0 - Sair");

        opcao = Convert.ToInt16(Console.ReadLine());

        return opcao;
    }

    public static void entradaDadosMesAno(ref int mes, ref int ano)
    {
        Console.WriteLine("De qual mês é o gasto?");
        mes = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("De qual ano é o gasto?");
        ano = Convert.ToInt16(Console.ReadLine());
    }
}
