using System;
using System.Data;
using System.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sysColab.Domain.Repositories;

namespace SysColab.Testes
{
    [TestClass]
    public class UnitTest1
    {
        DbConnection conexao;

        [TestInitialize]
        public void Iniciar()
        {
            conexao = DAO.ObterConexao();
        }
        [TestMethod]
        public void DevePasssarSeConexaoAberta()
        {
            Assert.AreEqual("Open", conexao.State.ToString());
        }     
        [TestMethod]
        public void DevePassarSeConexaoFechada()
        {
            DAO.FecharConexao(conexao);
            Assert.AreEqual("Closed", conexao.State.ToString());
        }
    }
}
