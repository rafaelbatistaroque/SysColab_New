using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SysColab.DAO.ConexaoDAO;
using SysColab.DAO.PRESTADORES.PrestadorDAO.Interfaces;
using SysColab.Dominio.Compartilhados.ValueObjects;
using SysColab.Dominio.PRESTADORES.Entities;

namespace SysColab.DAO.PRESTADORES.PrestadorDAO
{
    public class ServicoPrestadoDAO : IServicoPrestadoDAO
    {

        DbCommand SqlComando(string sqlComando)
        {
            DbConnection conexao = DAOConexao.ObterConexao();
            DbCommand comando = DAOConexao.ObterComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = sqlComando;

            return comando;
        }

        public void AtualizarFaturaServicoPrestado(ServicoPrestado fatura)
        {
            DbCommand comando = SqlComando("UPDATE tblfatura_prestadores_servicos " +
                                            "SET data_chegada = @dataChegada, mes_referencia = @mesRef, " +
                                                "valor_fatura = @valorFatura, data_vencimento = @dataVencimento, " +
                                                "status = @status, info_fatura_adicionais = @infoAdicionais " +
                                            "WHERE id_fatura = @idfatura");

            comando.Parameters.Add(new MySqlParameter("@dataChegada", fatura.DataChegada.DataFormatoBD));
            comando.Parameters.Add(new MySqlParameter("@mesRef", fatura.MesReferencia));
            comando.Parameters.Add(new MySqlParameter("@valorFatura", fatura.ValorFatura));
            comando.Parameters.Add(new MySqlParameter("@dataVencimento",fatura.DataVencimento.DataFormatoBD));
            comando.Parameters.Add(new MySqlParameter("@status", fatura.Status));
            comando.Parameters.Add(new MySqlParameter("@infoAdicionais", fatura.InfoAdicionaisFatura));
            comando.Parameters.Add(new MySqlParameter("@idfatura", fatura.IdFatura));
            comando.ExecuteNonQuery();


        }

        public void CriarFaturaServicoPrestado(ServicoPrestado fatura)
        {
            throw new NotImplementedException();
        }

        public void DeletarServicoPrestado(int id)
        {
            DbCommand comando = SqlComando("DELETE FROM tblfatura_prestadores_servicos WHERE id_fatura = @idfatura");
            comando.Parameters.Add(new MySqlParameter("@idfatura", id));
            comando.ExecuteNonQuery();
        }

        public ServicoPrestado ObterFaturaDeServicoPrestado(int id)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<ServicoPrestado> ObterTodasAsFaturasDeServicosPrestados(int idPrestador)
        {
            DbCommand comando = SqlComando("SELECT * FROM tblfatura_prestadores_servicos WHERE id_prestadores_servico = @idPrestador");
            comando.Parameters.Add(new MySqlParameter("@idPrestador", idPrestador));
            DbDataReader reader = DAOConexao.LerDadosRecebidosDoBanco(comando);

            ObservableCollection<ServicoPrestado> faturas = new ObservableCollection<ServicoPrestado>();
            while (reader.Read())
            {
                var fatura = new ServicoPrestado(
                    idPrestador: Convert.ToInt32(reader["id_prestadores_servico"]),
                    idFatura: Convert.ToInt32(reader["id_fatura"]),
                    dataChegada: new Data(reader["data_chegada"].ToString()),
                    dataVencimento: new Data(reader["data_vencimento"].ToString()),
                    mesReferencia: reader["mes_referencia"].ToString(),
                    valorFatura: reader["valor_fatura"].ToString(),
                    status: reader["status"].ToString(),
                    infoAdicionais: reader["info_fatura_adicionais"].ToString()
                );
                faturas.Add(fatura);
            }
            reader.Close();
            //FAZER: Implementar fechamento de conexao no try da interface
            DAOConexao.FecharConexao();

            return faturas;
        }

    }
}
