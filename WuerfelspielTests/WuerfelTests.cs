using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    public class WuerfelTests
    {
        [TestMethod]
        public void WuerfelAnlegenIstErfolgreich()
        {
            //Arrange 
            Wuerfel wuerfeln;

            //Act
            wuerfeln = new Wuerfeln(6);

            //Assert
            Assert.IsTrue(wuerfeln != null);
        }

        [TestMethod]
        public void AnzahlSeitenAbrufen()
        {
            //Arrange 
            Wuerfel wuerfeln;
            int seitenAnzahl = 6;
           
            //Act
            wuerfeln = new Wuerfel(seitenAnzahl);          

            //Assert
            Assert.AreEqual(wuerfeln.AnzahlSeiten, seitenAnzahl);
        }

        [TestMethod]
        public void WuerfelWuerfeln()
        {
            //Arrange 
            Wuerfel wuerfeln;
            int seitenAnzahl = 6;


            //Act
            wuerfeln = new Wuerfel(seitenAnzahl);
           int wuerfelzahl = wuerfeln.wuerfeln();
            
            //Assert
            Assert.AreEqual(wuerfelzahl = wuerfeln.WuerfelZahl);
            
        }

        [TestMethod]
        public void LetztesErgebnisAbrufen()
        {
            //Arrange 
            Wuerfel wuerfeln;
            int seitenAnzahl = 6;

            //Act
            wuerfeln = new Wuerfel(seitenAnzahl);
            wuerfeln.wuerfeln();

            //Assert
            Assert.IsNotNull(wuerfeln.LetztesErgebnis);
            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void WuerfelAnlegenFehlgeschlagenMinusTest()
        {
            //Arrange 

            Wuerfel wuerfeln;

            //Act
            wuerfeln = new Wuerfel(-1);
        }

        
    }
}