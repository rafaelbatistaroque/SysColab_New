using System.Data.Common;

namespace SysColab.Repositorios.ConexaoDAO.Interfaces
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
