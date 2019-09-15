using MySql.Data.MySqlClient;
using SysColab.DAO.ConexaoDAO;
using SysColab.DAO.PRESTADORES.PrestadorDAO.Interfaces;
using SysColab.Dominio.PRESTADORES.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Common;

namespace SysColab.DAO.PRESTADORES.PrestadorDAO
{
    public class PrestadorDAO : IPrestadorDAO
    {
        DbCommand SqlComando(string sqlComando)
        {
            DbConnection conexao = DAOConexao.ObterConexao();
            DbCommand comando = DAOConexao.ObterComando(conexao);
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
            DbCommand comando = SqlComando("DELETE FROM tblprestadores_servicos WHERE id_prestadores_servico = @id");
            comando.Parameters.Add(new MySqlParameter("@id", id));
            comando.ExecuteNonQuery();
        }

        public Prestador ObterPrestador(int id)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Prestador> ObterTodosPrestadores()
        {
            DbCommand comando = SqlComando("SELECT * FROM tblprestadores_servicos");
            DbDataReader reader = DAOConexao.LerDadosRecebidosDoBanco(comando);

            ObservableCollection<Prestador> prestadores = new ObservableCollection<Prestador>();
            while (reader.Read())
            {
                var prestador = new Prestador(
                    idPrestador: Convert.ToInt32(reader["id_prestadores_servico"]),
                    servico:  reader["servico"].ToString(),
                    infoAdicionaisPrestador: reader["infoAdicionais"].ToString()
                );
                prestadores.Add(prestador);
            }
            reader.Close();
            //FAZER: Implementar fechamento de conexao no try da interface
            DAOConexao.FecharConexao();
            return prestadores;
        }
    }
}
