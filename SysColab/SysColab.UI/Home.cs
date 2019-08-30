using MaterialSkin;
using MaterialSkin.Controls;
using SysColab.Servicos.NotificacaoServico;
using SysColab.Servicos.NotificacaoServico.Enums;
using System;

namespace SysColab.UI
{
    public partial class Home : MaterialForm
    {
        MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        public Home()
        {
            InitializeComponent();
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700,
                Primary.Indigo700, Accent.Lime400,
                TextShade.WHITE
                );

            pageFuncionarios.BringToFront();
        }

        private void BtnRH_Click(object sender, EventArgs e)
        {
            pageFuncionarios.BringToFront();

            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.Blue600, Primary.Blue700,
            Primary.Indigo700, Accent.Lime400,
            TextShade.WHITE
            );
        }

        private void BtnServicos_Click(object sender, EventArgs e)
        {
            pagePrestadores.BringToFront();

            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.Green600, Primary.Green700,
            Primary.Indigo700, Accent.Lime400,
            TextShade.WHITE
            );
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            Notificacao.Instancia.Notificar("Teste notificação", ETipoNotificacao.Erro);
            Notificacao.Instancia.Notificar("Teste notificação", ETipoNotificacao.Alerta);
            Notificacao.Instancia.Notificar("Teste notificação", ETipoNotificacao.Sucesso);
            Notificacao.Instancia.Notificar("Teste notificação", ETipoNotificacao.Info);
        }
    }
}
