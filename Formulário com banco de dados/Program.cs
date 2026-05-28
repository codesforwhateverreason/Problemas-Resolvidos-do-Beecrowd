using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulário_com_banco_de_dados
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            

            CriarTabela();

        }

        static void CriarTabela()
        {
            SQLiteConnection conn = DatabaseHelper.GetConnection();
            conn.Open();
            string comando = "CREATE TABLE IF NOT EXISTS Produtos (id INTEGER PRIMARY KEY AUTOINCREMENT, nome TEXT NOT NULL, quantidade INTEGER NOT NULL, preco REAL NOT NULL, grupo TEXT NOT NULL)";
            SQLiteCommand cmd = new SQLiteCommand(comando, conn);
            cmd.ExecuteNonQuery();
        }

        
    }
}
