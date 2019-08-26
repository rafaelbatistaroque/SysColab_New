using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sysColab.Domain.Enums;
using sysColab.Domain.ValueObjects;

namespace SysColab.Testes.Domínio.Test.ValueObjects
{
    [TestClass]
    public class CTPSTest
    {
        CTPS ctps;
        [TestInitialize]
        public void Inicial()
        {
            ctps = new CTPS("12", "123", "RJ");
        }
        [TestMethod]
        public void DevePassarSeParamentro_NumeroDaCTPS_EhDoTipoInteiro()
        {
            Assert.IsTrue(char.IsDigit(ctps.Numero.ToString(), 0));
            Assert.IsNotNull(ctps.Numero);
        }
        [TestMethod]
        public void DevePassarSeParamentro_SerieDaCTPS_EhDoTipoInteiro()
        {
            Assert.IsTrue(char.IsDigit(ctps.Serie.ToString(), 0));
        }
        [TestMethod]
        public void DevePassarSeParamentro_UFDaCTPS_EhSiglaDeUFBasileira()
        {
            Assert.IsTrue(Enum.IsDefined(typeof(EEstadosBrasileirosSigla), ctps.Uf));
        }
    }
}
