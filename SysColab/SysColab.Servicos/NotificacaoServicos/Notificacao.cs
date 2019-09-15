using SysColab.DAO.PRESTADORES.PrestadorDAO;
using SysColab.Dominio.Compartilhados.Entities.NotificacaoServico;
using SysColab.Dominio.PRESTADORES.Entities;
using SysColab.Servicos.NotificacaoServico.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SysColab.Servicos.NotificacaoServico
{
    public class Notificacao
    {
        internal static int TopNotificacao { get; set; }

        public static void Notificar(string notificacao, ETipoNotificacao tipoNotificacao)
        {
            if (TopNotificacao == 0 || TopNotificacao >= Screen.PrimaryScreen.Bounds.Height - 200) TopNotificacao = 30;
            else TopNotificacao += 100;

            switch (tipoNotificacao)
            {
                case ETipoNotificacao.Info:
                    new NotificacaoForm(TopNotificacao, notificacao, Color.FromArgb(105, 182, 190));
                    break;
                case ETipoNotificacao.Alerta:
                    new NotificacaoForm(TopNotificacao, notificacao, Color.FromArgb(243, 208, 63));
                    break;
                case ETipoNotificacao.Sucesso:
                    new NotificacaoForm(TopNotificacao, notificacao, Color.FromArgb(112, 196, 123));
                    break;
                case ETipoNotificacao.Erro:
                    new NotificacaoForm(TopNotificacao, notificacao, Color.FromArgb(244, 108, 80));
                    break;
            }
        }
    }
}
