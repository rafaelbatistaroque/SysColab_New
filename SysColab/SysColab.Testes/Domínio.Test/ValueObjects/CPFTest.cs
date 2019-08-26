using Microsoft.VisualStudio.TestTools.UnitTesting;
using sysColab.Domain.ValueObjects;

namespace SysColab.Testes.Domínio
{
    [TestClass]
    public class CPFTest
    {
        CPF cpf;

        [TestInitialize]
        public void Inicial()
        {
            cpf = new CPF("12345678910");
        }
        [TestMethod]
        public void DevePassarSeCPFNaoEhNuloOuVazio()
        { 
            Assert.IsNotNull(cpf.NumeroCPF);
        }
        [TestMethod]
        public void DevePassarSeCPFIgualOnzeDigitos()
        {
            Assert.IsTrue(cpf.NumeroCPF.Length == 11);
        }
    }
}
