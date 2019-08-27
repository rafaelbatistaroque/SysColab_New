using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SysColab.Dominio.ValueObjects
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
