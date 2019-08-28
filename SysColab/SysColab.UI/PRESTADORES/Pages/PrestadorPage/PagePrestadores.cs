using SysColab.Repositorios.PRESTADORES.PrestadorDAO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SysColab.UI.PRESTADORES.Pages.PrestadorPage
{
    public partial class PagePrestadores : UserControl
    {
        readonly PrestadorRepositorio prestadorRepositorio = new PrestadorRepositorio();
        public PagePrestadores()
        {
            InitializeComponent();
        }
        private void PagePrestador_Load(object sender, EventArgs e)
        {
            CarregarListaPrestadores();
        }

        private void CarregarListaPrestadores()
        {
            dgvPrestadores.DataSource = prestadorRepositorio.ObterTodosPrestadores();
            ConfigurarColunas();
        }
        void ConfigurarColunas()
        {
            dgvPrestadores.Columns[0].Visible = false;
            dgvPrestadores.Columns[1].HeaderText = "Prestador";
            dgvPrestadores.Columns[2].HeaderText = "Contato";
            dgvPrestadores.Columns[3].HeaderText = "Info";
        }
        #region Caixa de Pesquisa
        private void TxtPesquisarPrestado_Enter(object sender, EventArgs e)
        {
            if (txtPesquisarPrestado.Text == "Pesquisar...")
            {
                txtPesquisarPrestado.Text = "";
                txtPesquisarPrestado.ForeColor = Color.DarkBlue;
            }
        }

        private void TxtPesquisarPrestado_Leave(object sender, EventArgs e)
        {
            if (txtPesquisarPrestado.Text == "Pesquisar...")
            {
                txtPesquisarPrestado.Text = "";
                txtPesquisarPrestado.ForeColor = Color.FromArgb(192, 255, 192);
            }
        }

        private void TxtPesquisarPrestado_MouseHover(object sender, EventArgs e)
        {
            ToolTip balaoDicaTxtPesquisar = new ToolTip
            {
                ToolTipTitle = "Caixa de Pesquisa",
                UseFading = true,
                UseAnimation = true,
                IsBalloon = true,
                ShowAlways = true,
                AutoPopDelay = 5000,
                InitialDelay = 1000,
                ReshowDelay = 500
            };
            balaoDicaTxtPesquisar.SetToolTip(txtPesquisarPrestado, "Pesquisa as informações que estão na tabela de prestadores de serviço.");
        }
        #endregion
    }
}
