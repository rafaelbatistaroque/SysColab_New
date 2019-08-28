using SysColab.Repositorios.RH.FuncionarioDAO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SysColab.UI.RH.Pages.FuncionarioPage
{
    public partial class PageFuncionarios : UserControl
    {
        readonly FuncionarioRepositorio funcionarioRepositorios = new FuncionarioRepositorio();

        public delegate void BotaoDelegate(string botao);

        public PageFuncionarios()
        {
            InitializeComponent();
        }
        private void PageFuncionarios_Load(object sender, EventArgs e)
        {
            CarregarListaFuncionarios();
        }
        void CarregarListaFuncionarios()
        {
            this.dgvFuncionarios.DataSource = funcionarioRepositorios.ObterTodosFuncionarios();
            ConfigurarColunas();
            dgvFuncionarios.Refresh();
            dgvFuncionarios.ClearSelection();
        }
        void ConfigurarColunas()
        {
            dgvFuncionarios.Columns[0].Visible = false;
            dgvFuncionarios.Columns[1].HeaderText = "Nome";
            dgvFuncionarios.Columns[2].HeaderText = "Sobrenome";

            dgvFuncionarios.Columns[3].HeaderText = "CPF";

            dgvFuncionarios.Columns[4].Visible = false;
            dgvFuncionarios.Columns[5].Visible = false;
            dgvFuncionarios.Columns[6].Visible = false;
            dgvFuncionarios.Columns[7].Visible = false;
            dgvFuncionarios.Columns[8].HeaderText = "Email";
        }
        private void DgvFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //string cpf = dgvFuncionarios.CurrentRow.Cells[5].Value.ToString();
            //funcionarioRepositorios.DeletarFuncionario(cpf);
            MessageBox.Show(e.ColumnIndex.ToString());
            CarregarListaFuncionarios();
        }
        private void BtnNovo_Click_1(object sender, EventArgs e)
        {
            NovoFuncionario pageDashBoard = new NovoFuncionario();
            pageDashBoard.ShowDialog();
            CarregarListaFuncionarios();
        }
        #region Caixa de Pesquisa
        private void TxtPesquisar_Enter(object sender, EventArgs e)
        {
            if (txtPesquisar.Text == "Pesquisar...")
            {
                txtPesquisar.Text = "";
                txtPesquisar.ForeColor = Color.DarkBlue;
            }
        }
        private void TxtPesquisar_Leave(object sender, EventArgs e)
        {
            if (txtPesquisar.TextLength == 0)
            {
                txtPesquisar.Text = "Pesquisar...";
                txtPesquisar.ForeColor = Color.FromArgb(129, 195, 248);
            }
        }
        private void TxtPesquisar_MouseHover(object sender, EventArgs e)
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
            balaoDicaTxtPesquisar.SetToolTip(txtPesquisar, "Pesquisa as informações que estão na tabela de funcionários.");
        }
        #endregion
    }
}
