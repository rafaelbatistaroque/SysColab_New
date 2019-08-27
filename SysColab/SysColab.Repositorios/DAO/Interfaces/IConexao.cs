using System.Data.Common;

namespace SysColab.Repositorios
{
    interface IConexao
    {
        DbConnection ObterConexao();
        DbCommand ObterComando(DbConnection conexao);
        DbDataReader LerDadosRecebidosDoBanco(DbCommand comando);
        DbConnection AbrirConexao(DbConnection conexao);
        void FecharConexao(DbConnection conexao);
    }
}
