using SysColab.Servicos.NotificacaoServico;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SysColab.Dominio.Compartilhados.Entities.NotificacaoServico
{
    public partial class NotificacaoForm : Form
    {
        int topForm;
        public NotificacaoForm(int altura, string notificacao, Color corDeFundo)
        {
            InitializeComponent();

            lblNotificacao.Text = notificacao;
            this.BackColor = corDeFundo;
            topForm = altura;

            this.Show();
        }
        private void Notificacao_Load(object sender, EventArgs e)
        {
            this.Top = topForm;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 50;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Notificacao.altura = 0;
        }
        private void TimerNotificacao_Tick(object sender, EventArgs e)
        {
            timerNotificacao.Interval = 100;

            if (this.Opacity > 0)
                this.Opacity -= 0.1;
            else
            {
                this.Close();
                Notificacao.altura = 0;
            }
        }
    }
}
