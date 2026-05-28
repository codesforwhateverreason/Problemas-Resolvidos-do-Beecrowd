using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exercício_1_Banco_de_Dados
{
    internal class Program
    {
        static string connectionstring = "Data Source = bancodedados.db; Version = 3;";

        static void Main(string[] args)
        {
            CriarTabela();
            
            while (true)
            {
                Console.WriteLine("--- MENU ---\n1. Adicionar Produto\n2. Listar produtos\n3. Atualizar produtos\n4. Remover produtos\n5. Pesquisar produto por nome\n6. Verificar estado do estoque\n0. Sair");

                Console.Write("Escolha: ");

                int opcao;

                switch (opcao = int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Adicionar();
                        break;
                    case 2:
                        Listar();
                        break;
                    case 3:
                        Atualizar();
                        break;
                    case 4:
                        Remover();
                        break;
                    case 5:
                        Pesquisar();
                        break;
                    case 6:
                        VerificarProdutos();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }

                Console.WriteLine();
            }       
        }

        static void CriarTabela()
        {
            SQLiteConnection conn = new SQLiteConnection(connectionstring);
            conn.Open();
            string comando = "CREATE TABLE IF NOT EXISTS produtos (id INTEGER PRIMARY KEY AUTOINCREMENT, nome TEXT NOT NULL, quantidade INTEGER NOT NULL, preco DECIMAL(10, 2) NOT NULL, categoria TEXT NOT NULL)";
            SQLiteCommand cmd = new SQLiteCommand(comando, conn);
            cmd.ExecuteNonQuery();
        }

        static void Adicionar()
        {
            Console.Write("\nNome: ");
            string nome = Console.ReadLine();

            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.Write("Preço: ");
            decimal preco = decimal.Parse(Console.ReadLine());

            Console.Write("Categoria: ");
            string categoria = Console.ReadLine();

            SQLiteConnection conn = new SQLiteConnection(connectionstring);
            conn.Open();
            string comando = "INSERT INTO produtos (nome, quantidade, preco, categoria) VALUES (@nome, @quantidade, @preco, @categoria)";

            SQLiteCommand cmd = new SQLiteCommand(comando, conn);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@quantidade", quantidade);
            cmd.Parameters.AddWithValue("@preco", preco);
            cmd.Parameters.AddWithValue("@categoria", categoria);

            cmd.ExecuteNonQuery();

            Console.WriteLine("\nProduto adicionado com sucesso!");
        }

        static void Listar()
        {
            SQLiteConnection conn = new SQLiteConnection(connectionstring);
            conn.Open();

            string comando = "SELECT * FROM produtos";
            SQLiteCommand cmd = new SQLiteCommand(comando, conn);

            SQLiteDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("\n--- Lista de Produtos ---");

            while (reader.Read())
            {
                Console.WriteLine($"\nID: {reader["id"]} | Nome: {reader["nome"]} | Quantidade: {reader["quantidade"]} | Preço: {reader["preco"]} | Categoria: {reader["categoria"]}");
            }
        }

        static void Atualizar()
        { 
            while(true)
            {
                Console.WriteLine("\nO que quer atualizar?\n1. Nome\n2. Quantidade\n3. Preço\n4. Categoria\n0. Sair");

                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 0)
                {
                    break;
                }

                Console.Write("\nID do produto a atualizar: ");
                int id = int.Parse(Console.ReadLine());

                string comando;
                SQLiteCommand cmd;
                int linhas;

                SQLiteConnection conn = new SQLiteConnection(connectionstring);
                conn.Open();

                switch (opcao)
                {
                    case 1:
                        Console.Write("\nNovo nome: ");
                        string nome = Console.ReadLine();

                        comando = "UPDATE produtos SET nome = @nome WHERE id = @id";
                        cmd = new SQLiteCommand(comando, conn);
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@id", id);
                        linhas = cmd.ExecuteNonQuery();
                        Console.WriteLine(linhas > 0 ? "\nProduto atualizado com sucesso!" : "ID não encontrado.");
                        break;

                    case 2:
                        Console.Write("\nNova quantidade: ");
                        int quantidade = int.Parse(Console.ReadLine());

                        comando = "UPDATE produtos SET quantidade = @quantidade WHERE id = @id";
                        cmd = new SQLiteCommand(comando, conn);
                        cmd.Parameters.AddWithValue("@quantidade", quantidade);
                        cmd.Parameters.AddWithValue("@id", id);
                        linhas = cmd.ExecuteNonQuery();
                        Console.WriteLine(linhas > 0 ? "\nProduto atualizado com sucesso!" : "ID não encontrado.");
                        break;

                    case 3:
                        Console.Write("\nNovo preço: ");
                        decimal preco = decimal.Parse(Console.ReadLine());

                        comando = "UPDATE produtos SET preco = @preco WHERE id = @id";
                        cmd = new SQLiteCommand(comando, conn);
                        cmd.Parameters.AddWithValue("@preco", preco);
                        cmd.Parameters.AddWithValue("@id", id);
                        linhas = cmd.ExecuteNonQuery();
                        Console.WriteLine(linhas > 0 ? "\nProduto atualizado com sucesso!" : "ID não encontrado.");
                        break;

                    case 4:
                        Console.Write("\nNova categoria: ");
                        string categoria = Console.ReadLine();

                        comando = "UPDATE produtos SET categoria = @categoria WHERE id = @id";
                        cmd = new SQLiteCommand(comando, conn);
                        cmd.Parameters.AddWithValue("@categoria", categoria);
                        cmd.Parameters.AddWithValue("@id", id);
                        linhas = cmd.ExecuteNonQuery();
                        Console.WriteLine(linhas > 0 ? "\nProduto atualizado com sucesso!" : "ID não encontrado.");
                        break;

                    default:
                        Console.WriteLine("\nOpção Inválida");
                        break;
                }
            }
        }

        static void Remover()
        {
            Console.Write("\nID do produto a remover: ");
            int id = int.Parse(Console.ReadLine());

            SQLiteConnection conn = new SQLiteConnection(connectionstring);
            conn.Open();

            string comando = "DELETE FROM produtos WHERE id = @id";
            SQLiteCommand cmd = new SQLiteCommand(comando, conn);
            cmd.Parameters.AddWithValue("@id", id);

            int linhas = cmd.ExecuteNonQuery();

            Console.WriteLine(linhas > 0 ? "\nProduto removido com sucesso!" : "ID não encontrado.");

            
        }

        static void Pesquisar()
        {
            Console.Write("\nNome do produto a pesquisar: ");
            string nome = Console.ReadLine();

            SQLiteConnection conn = new SQLiteConnection(connectionstring);
            conn.Open();

            string comando = "SELECT id, nome, quantidade, preco, categoria FROM produtos WHERE nome = @nome";
            SQLiteCommand cmd = new SQLiteCommand(comando, conn);
            cmd.Parameters.AddWithValue("@nome", nome);

            SQLiteDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
                Console.WriteLine($"\nID: {reader["id"]} | Nome: {reader["nome"]} | Quantidade: {reader["quantidade"]} | Preco: {reader["preco"]} | Categoria: {reader["categoria"]}");
            else Console.WriteLine("\nProduto não encontrado");
        }

        static void VerificarProdutos()
        {
            SQLiteConnection conn = new SQLiteConnection(connectionstring);
            conn.Open();

            string comando = "SELECT * FROM produtos WHERE quantidade < 5";
            SQLiteCommand cmd = new SQLiteCommand(comando, conn);

            SQLiteDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("\n--- Produtos em Estado de Alerta ---");

            while (reader.Read())
            {
                Console.WriteLine($"\nID: {reader["id"]} | Nome: {reader["nome"]} | Quantidade: {reader["quantidade"]} | Preço: {reader["preco"]} | Categoria: {reader["categoria"]}");
            }
        }
    }
}
