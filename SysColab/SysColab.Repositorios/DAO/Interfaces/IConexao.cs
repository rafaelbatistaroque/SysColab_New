using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sysColab.Repositories.DAO.Interfaces
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
