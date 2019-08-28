using MaterialSkin;
using MaterialSkin.Controls;
using SysColab.Dominio.PUBLICOS.ValueObjects;
using SysColab.Dominio.RH.Entities;
using SysColab.Dominio.RH.ValueObjects;
using SysColab.Repositorios.RH.FuncionarioDAO;
using System;
using System.Windows.Forms;

namespace SysColab.UI.RH.Pages.FuncionarioPage
{
    public partial class NovoFuncionario : MaterialForm
    {
        public NovoFuncionario()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            this.Text = "Novo Funcionário";
        }
        //FAZER: Substituir textBox MaterialSkin pela Textbox do WinForm.
        private void BtnSalvar_Click_1(object sender, EventArgs e)
        {
            Funcionario funcionario;

            try
            {
                DateTime dataConvertida = Convert.ToDateTime(string.Format(txtDataNasc.Text, "yyyy-MM-dd"));
                funcionario = new Funcionario(
                    new Nome(txtNome.Text, txtSobre.Text),
                    new CPF(txtCpf.Text),
                    new CTPS(txtCtpsNr.Text, txtCtpsSerie.Text, txtCtpsUf.Text),
                    new PIS(""),
                    dataNasc: dataConvertida,
                    new Email(txtEmail.Text)
                );

                FuncionarioRepositorio funcionarioRepositorio = new FuncionarioRepositorio();
                funcionarioRepositorio.CriarFuncionario(funcionario);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
