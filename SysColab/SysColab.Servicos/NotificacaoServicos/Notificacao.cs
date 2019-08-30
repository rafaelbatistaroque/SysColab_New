using SysColab.Dominio.Compartilhados.Entities.NotificacaoServico;
using SysColab.Servicos.NotificacaoServico.Enums;
using System.Drawing;
using System.Windows.Forms;

namespace SysColab.Servicos.NotificacaoServico
{
    public class Notificacao
    {
        private Notificacao() { }
        private static Notificacao _instancia;

        internal static int altura;

        public static Notificacao Instancia => ObterInstancia();

        static Notificacao ObterInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new Notificacao();
            }
            return _instancia;
        }
        public void Notificar(string notificacao, ETipoNotificacao tipoNotificacao)
        {
            if (altura == 0 || altura >= Screen.PrimaryScreen.Bounds.Height - 200) altura = 30;
            else altura += 100;

            switch (tipoNotificacao)
            {
                case ETipoNotificacao.Info:
                    new NotificacaoForm(altura, notificacao, Color.FromArgb(105, 182, 190));
                    break;
                case ETipoNotificacao.Alerta:
                    new NotificacaoForm(altura, notificacao, Color.FromArgb(243, 208, 63));
                    break;
                case ETipoNotificacao.Sucesso:
                    new NotificacaoForm(altura, notificacao, Color.FromArgb(112, 196, 123));
                    break;
                case ETipoNotificacao.Erro:
                    new NotificacaoForm(altura, notificacao, Color.FromArgb(244, 108, 80));
                    break;
            }
        }
    }
}
