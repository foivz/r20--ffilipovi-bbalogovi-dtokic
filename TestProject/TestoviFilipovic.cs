using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vedrana;

namespace TestProject
{
    [TestClass]
    public class TestoviFilipovic
    {
        [TestMethod]
        public void ProvjeraAutentifikacije()
        {
            //Arrange

            //Act
            var zap = zaposlenik.Autenfikacija("admin", "admin1");

            //Assert
            Assert.IsNotNull(zap);
        }

        [TestMethod]
        public void PromjenaSifre()
        {
            //Arrange
            var zap = zaposlenik.Autenfikacija("admin", "admin");

            //Act
            zap.PromjenaLozinke("admin1");
            zap = null;
            zap = zaposlenik.Autenfikacija("admin", "admin1");

            //Assert
            Assert.IsNotNull(zap);
        }
    }
}
