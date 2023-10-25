using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DAL.Properties;

namespace DAL
{
    public class Conexao
    {
        public static string mensagem = string.Empty;
        private static string strConn = Settings.Default.StrConexao;
        private static MySqlConnection conn = null;

        public static MySqlConnection obterConexao()
        {
            conn = new MySqlConnection(strConn);
            try
            {
                conn.Open();
            }
            catch (MySqlException erro)
            {
                conn = null;
                mensagem = erro.ToString();
            }
            return conn;
        }

        public static MySqlConnection fecharConexao()
        {
            conn = new MySqlConnection(strConn);
            try
            {
                conn.Close();
            }
            catch (MySqlException erro)
            {

                conn = null;
                mensagem = erro.ToString();
            }
            return conn;
        }
    }
}
