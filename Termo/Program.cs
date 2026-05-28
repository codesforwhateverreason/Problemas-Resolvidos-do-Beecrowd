using System.Diagnostics.Metrics;
using System.Net;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] palavras = { "sagaz", "termo", "negro", "mexer", "nobre", "senso", "afeto", "algoz", "fazer", "plena",
                              "assim", "sobre", "poder", "vigor", "sutil", "fosse", "cerne", "ideia", "sanar", "audaz",
                              "moral", "inato", "muito", "desde", "justo", "honra", "sonho", "torpe", "amigo", "etnia",
                              "anexo", "dengo", "tange", "haver", "lapso", "expor", "tempo", "seara", "saber", "casal",
                              "dizer", "ardil", "estar", "pesar", "dever", "causa", "tenaz", "ainda", "sendo", "temor",
                              "crivo", "brado", "coser", "genro", "comum", "posse", "prole", "assaz", "corja", "fugaz",
                              "ceder", "pauta", "censo", "culto", "atroz", "digno", "mundo", "forte", "mesmo", "vulgo",
                              "criar", "todos", "jeito", "pudor", "dogma", "valha", "denso", "louco", "ordem", "limbo",
                              "regra", "pedir", "feliz", "homem", "ajuda", "clava", "usura", "impor", "banal", "coisa",
                              "falso", "legal", "forma", "falar", "prosa", "verso", "servo", "tenro", "conto", "cunho",
                              "desse", "viril", "presa", "valor", "manso", "lindo", "custo", "genro", "pasta", "costa",
                              "gente", "mente", "modos", "malas", "palha", "ponta", "ronda", "carro", "corvo", "maior",
                              "perto", "longe", "coifa", "garfo", "corte", "dente", "creme", "pente", "preto", "verde",
                              "cores", "prece", "germe", "grato", "gatos", "lucro", "falha", "susto", "juras", "junto",
                              "justo", "janta", "prato", "morno", "forno", "forte", "fraco", "antes", "meses", "afins",
                              "lugar", "lento", "parte", "parto", "fonte", "forca", "vento", "chuva", "nevar", "solar",
                              "tomar", "achar", "ficar", "ferro", "prata", "clima", "gerir", "pouso", "aviso", "andar",
                              "porta", "camas", "clero", "crepe", "grifo", "cravo", "febre", "lebre", "larva", "livro",
                              "largo", "podam", "trens", "fuzil", "areio", "lagos", "areia", "praia", "trave", "treva",
                              "pleno", "plano", "pires", "hotel", "longo", "certo", "livre", "gruta", "fruta", "frete"};


        char[] letras = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        int vitoriasseguidas = 0;

        Console.WriteLine("Sintaxe:\nO - Letra correta no lugar correto\nV - Letra correta no lugar errado\nX - Letra errada\n");

        while (true)
        {
            Console.WriteLine("Você quer jogar?\nS  N");
            char quer = char.Parse(Console.ReadLine());

            if (quer == 'N')
            {
                Console.WriteLine("Ok. Até a próxima!");
                break;
            }
            else if (quer == 'S')
            {
                Random indice = new Random();

                string resposta = palavras[indice.Next(0, palavras.Length)];

                List<char> letrasdisponiveis = letras.ToList();
                int[] repeticoesresposta = new int[26];

                bool ganhou = false;

                for (int i = 0; i < 26; i++)
                {
                    foreach (char a in resposta)
                    {
                        if (a == letras[i])
                            repeticoesresposta[i]++;
                    }
                }


                for (int i = 1; i <= 6; i++)
                {
                    Console.WriteLine();

                    Console.WriteLine($"Palpite {i}");
                    string palpite = Console.ReadLine();

                    ganhou = verificarpalpite(palpite, resposta, repeticoesresposta, letras, ref letrasdisponiveis);

                    if (ganhou)  
                        break;
                }

                if (ganhou)
                {
                    Console.WriteLine("\nParabéns. Você acertou!");
                    vitoriasseguidas++;
                }
                else
                {
                    Console.WriteLine($"\nQue pena! A palavra era: {resposta}");
                    vitoriasseguidas = 0;
                }

                Console.WriteLine($"Vítorias Seguidas: {vitoriasseguidas}\n");
            }
            else Console.WriteLine("Opção Inválida!");
        }

    }

    static bool verificarpalpite(string palpite, string resposta, int[] repeticoesresposta, char[] letras, ref List<char> letrasdisponiveis)
    {
        
        int[] repeticoespalpite = new int[26];

        StringBuilder resultado = new StringBuilder();

        /*
        foreach (int i in repeticoesresposta)
            Console.Write(i + " ");
        Console.WriteLine();

        foreach (int i in repeticoespalpite)
            Console.Write(i + " ");
        Console.WriteLine();
        */

        for (int i = 0; i < palpite.Length; i++)
        {
            if (repeticoespalpite[Array.IndexOf(letras, palpite[i])] < repeticoesresposta[Array.IndexOf(letras, palpite[i])])
            {
                if (palpite[i] == resposta[i])
                    resultado.Append('O');
                else resultado.Append('V');

                repeticoespalpite[Array.IndexOf(letras, palpite[i])]++;

                if (letrasdisponiveis.IndexOf(palpite[i]) != -1)
                    letrasdisponiveis[letrasdisponiveis.IndexOf(palpite[i])] = char.ToUpper(letrasdisponiveis[letrasdisponiveis.IndexOf(palpite[i])]);
            }
            else
            {
                if (letrasdisponiveis.Contains(palpite[i]))
                    letrasdisponiveis.Remove(palpite[i]);
                resultado.Append('X');
            }
        }

        Console.WriteLine(resultado);

        if (resultado.ToString() == "OOOOO")
            return true;

        StringBuilder letrasrrestantes = new StringBuilder();

        foreach (char a in letrasdisponiveis)
            letrasrrestantes.Append(a).Append(' ');

        Console.WriteLine(letrasrrestantes);

        return false;
    }
}