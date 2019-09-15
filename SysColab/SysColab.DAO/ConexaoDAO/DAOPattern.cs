using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Common;

namespace SysColab.DAO.ConexaoDAO
{
    public class DAOConexao
    {
        private static DbConnection _conexao;
        public static DbConnection ObterConexao()
        {
            string servidor = "localHost";
            string bancoDeDados = "db_syscolab";
            string usuario = "root";
            string senha = "9gregokirios";

            string strconexao = $"Server={servidor};Database={bancoDeDados};Uid={usuario};Pwd={senha};";
            _conexao = new MySqlConnection(strconexao);
            return AbrirConexao();
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
        static DbConnection AbrirConexao()
        {
            if (_conexao.State == ConnectionState.Closed)
                _conexao.Open();
            return _conexao;
        }
        public static void FecharConexao()
        {
            if (_conexao.State == ConnectionState.Open)
                _conexao.Close();
        }
    }
}
