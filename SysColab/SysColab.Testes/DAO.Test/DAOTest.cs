using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Common;

namespace SysColab.DAO.ConexaoDAO
{
    [TestClass]
    public class DAOTest
    {
        DbConnection conexao;

        [TestInitialize]
        public void Iniciar()
        {
            conexao = DAOConexao.ObterConexao();
        }
        [TestMethod]
        public void DevePasssarSeConexaoAberta()
        {
            Assert.AreEqual("Open", conexao.State.ToString());
        }
        [TestMethod]
        public void DevePassarSeConexaoFechada()
        {
            DAOConexao.FecharConexao();
            Assert.AreEqual("Closed", conexao.State.ToString());
        }
    }
}
