using System;
using Vedrana;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class TestoviBalogovic
    {
        [TestMethod]
        public void DodavanjeNovogKorisnika()
        {
            //Arrange
            new korisnik("TestIme", "TestPrezime", "TestOIB1", "TestAdresa", DateTime.Now, "TestKontakt", 1,
                new System.Collections.Generic.List<imaUslugu>(), "/", "/");

            //Act
            var kor = korisnik.PretragaKorisnika(false, "TestIme", "TestPrezime");

            //Assert
            Assert.IsNotNull(kor);
        }
        [TestMethod]
        public void PromjenaSobeKorisniku()
        {
            //Arrange
            var kor = new korisnik("TestIme2", "TestPrezime2", "TestOIB2", "TestAdresa2", DateTime.Now, "TestKontakt2", 1,
                new System.Collections.Generic.List<imaUslugu>(), "/", "/");

            //Act
            kor.PromjeniSobu(2);

            //Assert
            Assert.AreEqual(2, kor.brojSobe);
        }
    }
}
