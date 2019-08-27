using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data.Common;

namespace SysColab.Repositorios.DAO
{
    public class DAO
    {
        public static DbConnection ObterConexao()
        {
            string servidor = "localHost";
            string bancoDeDados = "db_syscolab";
            string usuario = "root";
            string senha = "9gregokirios";

            string strconexao = $"Server={servidor};Database={bancoDeDados};Uid={usuario};Pwd={senha};";
            DbConnection conexao = new MySqlConnection(strconexao);
            return AbrirConexao(conexao);
        }
        public static DbCommand ObterComando(DbConnection conexao)
        {
            DbCommand comando = conexao.CreateCommand();
            return comando;
        }
        public static DbDataReader LerDadosRecebidosDoBanco(DbCommand comando)
        {
            return comando.ExecuteReader();
        }
        static DbConnection AbrirConexao(DbConnection conexao)
        {
            switch (conexao.State.ToString())
            {
                case "Closed":
                    conexao.Open();
                    return conexao;
                default:
                    return conexao;
            }
        }
        public static void FecharConexao(DbConnection conexao)
        {
            if (conexao.State.ToString() == "Open")
                conexao.Close();
        }
    }
}
