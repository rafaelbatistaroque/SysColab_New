using sysColab.Domain.Repositories;
using System;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;

namespace SysColab.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DbConnection conexao = DAO.ObterConexao();
            //DbCommand comando = DAO.ObterComando(conexao);
            //comando.CommandType = CommandType.Text;
            //comando.CommandText = "Select * from tblFuncionarios";

            //DbDataReader reader = DAO.LerDadosRecebidosDoBanco(comando);
            //DataTable data = new DataTable();
            //data.Load(reader);


            //dgvTest.DataSource = data;
            //dgvTest.Refresh();
        }
    }
}
