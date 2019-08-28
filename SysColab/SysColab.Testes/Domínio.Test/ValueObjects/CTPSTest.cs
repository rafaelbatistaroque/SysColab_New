using Microsoft.VisualStudio.TestTools.UnitTesting;
using SysColab.Dominio.RH.Enums;
using System;

namespace SysColab.Dominio.RH.ValueObjects
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
        public void DevePassarSe_NumeroDaCTPS_EhDoTipoInteiro()
        {
            Assert.IsTrue(char.IsDigit(ctps.Numero.ToString(), 0));
        }
        [TestMethod]
        public void DevePassar_SerieDaCTPS_EhDoTipoInteiro()
        {
            Assert.IsTrue(char.IsDigit(ctps.Serie.ToString(), 0));
        }
        [TestMethod]
        public void DevePassar_UFDaCTPS_EhSiglaDeUFBrasileira()
        {
            Assert.IsTrue(Enum.IsDefined(typeof(EEstadosBrasileirosSigla), ctps.Uf));
        }
    }
}
