using MySql.Data.MySqlClient;
using SysColab.DAO.Compartilhados;
using SysColab.DAO.PRESTADORES.PrestadorDAO.Interfaces;
using SysColab.Dominio.Compartilhados.ValueObjects;
using SysColab.Dominio.PRESTADORES.Entities;
using SysColab.Servicos.NotificacaoServico;
using SysColab.Servicos.NotificacaoServico.Enums;
using System;
using System.Collections.ObjectModel;

namespace SysColab.DAO.PRESTADORES.PrestadorDAO
{
    public class ServicoPrestadoDAO : IServicoPrestadoDAO
    {
        public void AtualizarFaturaServicoPrestado(ServicoPrestado fatura)
        {
            var comando = Comando.LerComando("UPDATE tblfatura_prestadores_servicos " +
                                                    "SET data_chegada = @dataChegada, mes_referencia = @mesRef, " +
                                                        "valor_fatura = @valorFatura, data_vencimento = @dataVencimento, " +
                                                        "status = @status, info_fatura_adicionais = @infoAdicionais " +
                                                    "WHERE id_fatura = @idfatura");

            comando.Parameters.Add(new MySqlParameter("@dataChegada", fatura.DataChegada.DataFormatoBD));
            comando.Parameters.Add(new MySqlParameter("@mesRef", fatura.MesReferencia));
            comando.Parameters.Add(new MySqlParameter("@valorFatura", fatura.ValorFatura));
            comando.Parameters.Add(new MySqlParameter("@dataVencimento", fatura.DataVencimento.DataFormatoBD));
            comando.Parameters.Add(new MySqlParameter("@status", fatura.Status));
            comando.Parameters.Add(new MySqlParameter("@infoAdicionais", fatura.InfoAdicionaisFatura));
            comando.Parameters.Add(new MySqlParameter("@idfatura", fatura.IdFatura));
            comando.ExecuteNonQuery();

            Notificacao.Notificar("Fatura Atualizada ", ETipoNotificacao.Sucesso);
        }

        public void CriarFaturaServicoPrestado(ServicoPrestado fatura)
        {
            throw new NotImplementedException();
        }

        public void DeletarServicoPrestado(string id)
        {
            var comando = Comando.LerComando("DELETE FROM tblfatura_prestadores_servicos WHERE id_fatura = @idfatura");
            comando.Parameters.Add(new MySqlParameter("@idfatura", id));
            comando.ExecuteNonQuery();

            Notificacao.Notificar("Fatura deletada ", ETipoNotificacao.Sucesso);
        }

        public ServicoPrestado ObterFaturaDeServicoPrestado(int id)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<ServicoPrestado> ObterTodasAsFaturasDeServicosPrestados(string idPrestador)
        {
            var comando = Comando.LerComando("SELECT * FROM tblfatura_prestadores_servicos " +
                                                "WHERE id_prestadores_servico = @idPrestador");

            comando.Parameters.Add(new MySqlParameter("@idPrestador", idPrestador.ToString()));
            var reader = DAOConexao.LerDadosRecebidosDoBanco(comando);

            var faturas = new ObservableCollection<ServicoPrestado>();
            while (reader.Read())
            {
                faturas.Add(
                    new ServicoPrestado(
                        idPrestador: reader["id_prestadores_servico"].ToString(),
                        idFatura: reader["id_fatura"].ToString(),
                        dataChegada: new Data(reader["data_chegada"].ToString()),
                        dataVencimento: new Data(reader["data_vencimento"].ToString()),
                        mesReferencia: reader["mes_referencia"].ToString(),
                        valorFatura: reader["valor_fatura"].ToString(),
                        status: reader["status"].ToString(),
                        infoAdicionais: reader["info_fatura_adicionais"].ToString()
                ));
            }
            reader.Close();
            DAOConexao.FecharConexao();

            return faturas;
        }

    }
}
