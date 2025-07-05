using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace Hospital.Utilitarios
{
    internal class Conexao
    {
        public static MySqlConnection conexao;

        public static MySqlConnection Conectar()
        {
            try
            {
                string strconexao = "server=localhost; port=3306; userid=root; password=root123; database=Hospital";
                conexao = new MySqlConnection(strconexao);
                conexao.Open();
                Console.WriteLine("Conexão realizada com sucesso!");
                return conexao;
                
            }catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar ao Banco de Dados!");
            }
        }

        public static void FecharConexao()
        {
            conexao.Clone();
        }
    }
}
