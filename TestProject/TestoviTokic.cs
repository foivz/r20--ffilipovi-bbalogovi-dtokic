using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vedrana;

namespace TestProject
{
    [TestClass]
    public class TestoviTokic
    {
        [TestMethod]
        public void DodavanjeJelaUBazu()
        {
            //Arrange
            new jelo("TestJelo", "Dorucak", new System.Collections.Generic.List<int>(), new System.Collections.Generic.List<double>());

            //Act
            var jela = jelo.PretraziJelaPoImenu("TestJelo");

            //Assert
            Assert.IsNotNull(jela);
        }
        [TestMethod]
        public void PretragaJelaPoTipu()
        {
            //Act
            var jela = jelo.PopisJelaPoTipu("Dorucak");

            //Assert
            foreach (var j in jela)
            {
                Assert.AreEqual("Dorucak", j.tipJela);
            }
        }
    }
}
