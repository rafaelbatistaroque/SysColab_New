using SysColab.Servicos.NotificacaoServico;
using SysColab.Servicos.NotificacaoServico.Enums;
using System;
using System.Data;
using System.Data.Common;

namespace SysColab.DAO.Compartilhados
{
    public class Comando
    {
        public static DbCommand LerComando(string sqlComando)
        {
            try
            {
                var conexao = DAOConexao.ObterConexao();
                var comando = DAOConexao.ObterComando(conexao);
                comando.CommandType = CommandType.Text;
                comando.CommandText = sqlComando;
                return comando;

            }
            catch (Exception err)
            {
                Notificacao.Notificar(err.Message.ToString(), ETipoNotificacao.Erro);
                throw;
            }
        }
    }
}
