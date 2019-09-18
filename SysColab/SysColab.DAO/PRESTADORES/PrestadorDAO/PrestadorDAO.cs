using MySql.Data.MySqlClient;
using SysColab.DAO.Compartilhados;
using SysColab.DAO.PRESTADORES.PrestadorDAO.Interfaces;
using SysColab.Dominio.PRESTADORES.Entities;
using SysColab.Servicos.NotificacaoServico;
using SysColab.Servicos.NotificacaoServico.Enums;
using System;
using System.Collections.ObjectModel;

namespace SysColab.DAO.PRESTADORES.PrestadorDAO
{
    public class PrestadorDAO : IPrestadorDAO
    {
        public void AtualizarPrestador(Prestador prestador)
        {
            throw new NotImplementedException();
        }

        public void CriarPrestador(Prestador prestador)
        {
            var comando = Comando.LerComando("INSERT INTO tblprestadores_servicos" +
                                            "(id_prestadores_servico, servico, infoAdicionais)" +
                                            "VALUES(@idGuid, @servico, @infoAdicionais)");

            comando.Parameters.Add(new MySqlParameter("@idGuid", prestador.IdPrestador));
            comando.Parameters.Add(new MySqlParameter("@servico", prestador.Servico));
            comando.Parameters.Add(new MySqlParameter("@infoAdicionais", prestador.InfoAdicionaisPrestador));
            comando.ExecuteNonQuery();

            DAOConexao.FecharConexao();

            Notificacao.Notificar("Prestador adicionado", ETipoNotificacao.Sucesso);
        }

        public void DeletarPrestador(string id)
        {
            var comando = Comando.LerComando("DELETE FROM tblprestadores_servicos WHERE id_prestadores_servico = @id");
            comando.Parameters.Add(new MySqlParameter("@id", id));
            comando.ExecuteNonQuery();

            DAOConexao.FecharConexao();
            Notificacao.Notificar("Prestador excluído", ETipoNotificacao.Sucesso);
        }

        public Prestador ObterPrestador(int id)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Prestador> ObterTodosPrestadores()
        {
            var comando = Comando.LerComando("SELECT * FROM tblprestadores_servicos");
            var reader = DAOConexao.LerDadosRecebidosDoBanco(comando);

            var prestadores = new ObservableCollection<Prestador>();
            while (reader.Read())
            {
                prestadores.Add(
                    new Prestador(
                        idPrestador: reader["id_prestadores_servico"].ToString(),
                        servico: reader["servico"].ToString(),
                        infoAdicionaisPrestador: reader["infoAdicionais"].ToString()
                ));
            }
            reader.Close();
            DAOConexao.FecharConexao();

            return prestadores;
        }
    }
}
