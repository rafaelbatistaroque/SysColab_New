using SysColab.Dominio.PRESTADORES.Entities;
using SysColab.Repositorios.ConexaoDAO;
using SysColab.Repositorios.PRESTADORES.PrestadorDAO.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysColab.Repositorios.PRESTADORES.PrestadorDAO
{
    public class PrestadorRepositorio : IPrestadorRepositorio
    {
        private DbConnection _conexao;
        DbCommand SqlComando(string sqlComando)
        {
            _conexao = DAO.ObterConexao();
            DbCommand comando = DAO.ObterComando(_conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = sqlComando;

            return comando;
        }
        public void AtualizarPrestador(Prestador prestador)
        {
            throw new NotImplementedException();
        }

        public void CriarPrestador(Prestador prestador)
        {
            throw new NotImplementedException();
        }

        public void DeletarPrestador(int id)
        {
            throw new NotImplementedException();
        }

        public Prestador ObterPrestador(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable ObterTodosPrestadores()
        {
            DbCommand comando = SqlComando("SELECT * FROM tblprestadores_servicos");
            DbDataReader reader = DAO.LerDadosRecebidosDoBanco(comando);

            DataTable dadosPrestador = new DataTable();
            dadosPrestador.Load(reader);

            reader.Close();
            DAO.FecharConexao(_conexao);

            return dadosPrestador;
        }
    }
}
