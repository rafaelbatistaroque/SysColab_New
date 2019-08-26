﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using sysColab.Domain.Repositories;
using System.Data.Common;

namespace SysColab.Testes
{
    [TestClass]
    public class DAOTest
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
