using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {

        int N = int.Parse(Console.ReadLine());

        int[][] matriz_jaggedarray= new int[N][];

        for (int i = 0; i < N; i++)
        {
            int[] linha = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            matriz_jaggedarray[i] = linha;
        }

        int[][] somasacumuladas = new int[N][];

        for (int i = N, j = 0; i >= 1; i--, j++)
            somasacumuladas[j] = new int[i];

        for (int i = 0; i < N; i++)
            somasacumuladas[i][0] = matriz_jaggedarray[0][i];

        for (int coluna = 1; coluna < N; coluna++)
        {
            for (int linha = 0; linha < N - coluna; linha++)
            {
                // Skip() - Pula tantos itens na sequência. Take() - Pega os primeiros tantos itens na sequência. Sum() - Soma os itens. Tudo do LINQ.
                somasacumuladas[linha][coluna] = matriz_jaggedarray[coluna].Skip( linha).Take(coluna + 1).Sum();

                // Encontra menor valor entre as duas últimas somas das últimas linhas e soma a menor delas.
                somasacumuladas[linha][coluna] += Math.Min(somasacumuladas[linha][coluna - 1], somasacumuladas[linha + 1][coluna - 1]);
            }
        }

        Console.WriteLine(somasacumuladas[0][N - 1]);


        #region Comentário aqui só se eu precisar desse código de novo
        /*
         * Código Guloso de achar a coluna adjacente com menor soma (achei muito daora fazer, mas não era essa a solução triste, mas fazer o que, né? ¯\_(ツ)_/¯)
        int N = int.Parse(Console.ReadLine());

        int[,] matriz = new int[N, N];

        int[] somacolunas = new int[N];

        for (int i = 0; i < N; i++)
        {
            int[] linha = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int j = 0; j < N; j++)
            {
                matriz[i, j] = linha[j];
                somacolunas[j] += matriz[i, j];
            }
        }

        int somaminima = somacolunas.Min();

        Console.WriteLine($"Menor Soma: {somaminima}");

        int[] colunasvisitadas = new int[N];
        Array.Fill(colunasvisitadas, -1);

        colunasvisitadas[0] = Array.IndexOf(somacolunas, somaminima);

        int colunaesquerda = colunasvisitadas[0];
        int colunadireita = colunasvisitadas[0];


        for (int i = 1; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (!colunasvisitadas.Contains(j))
                    somacolunas[j] -= matriz[i - 1, j];
            }

            int somacolunadireita = 0;
            int somacolunaesquerda = 0;

            if (colunadireita + 1 < N && !colunasvisitadas.Contains(colunadireita + 1))
                somacolunadireita = somacolunas[colunadireita + 1];

            if (colunaesquerda - 1 > -1 && !colunasvisitadas.Contains(colunaesquerda - 1))
                somacolunaesquerda = somacolunas[colunaesquerda - 1];

            int menorsoma = 0;

            if (somacolunadireita == 0)
                menorsoma = somacolunaesquerda;
            else if (somacolunaesquerda == 0)
                menorsoma = somacolunadireita;
            else menorsoma = Math.Min(somacolunadireita, somacolunaesquerda);

            Console.WriteLine($"Menor Soma: {menorsoma}");


            if (menorsoma == somacolunadireita)
                colunadireita++;
            else colunaesquerda--;

            somaminima += menorsoma;
            colunasvisitadas[i] = Array.IndexOf(somacolunas, menorsoma); 
        }

        Console.WriteLine(somaminima);
        */
        #endregion
    }
}