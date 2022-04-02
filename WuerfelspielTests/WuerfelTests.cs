using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    public class WuerfelTests
    {
        [TestMethod]
        public void DummyTest()
        {
            // Dieser Test ist hier, um eine GitHub-Funktion zu testen. 
            // Einfach löschen :)
            Assert.IsTrue(true);// is tatsächlich true :O
        }

        [TestMethod]
        public void WuerfelAnlegenErfolgreich()
        {
            Wuerfel wuerfel1;

            wuerfel1 = new Wuerfel(6);

            Assert.IsTrue(wuerfel1 != null);
        }

        [TestMethod]
        public void AnzahlSeitenAbrufen()
        {
            Wuerfel wuerfel1;
            int seitenAnzahl = 6;

            wuerfel1 = new Wuerfel(seitenAnzahl);
            Console.WriteLine(wuerfel1.AnzahlSeiten);

            Assert.IsEqual(wuerfel1.AnzahlSeiten, seitenAnzahl);
        }

        [TestMethod]
        public void WuerfelWuerfeln()
        {
            Wuerfel wuerfel1;
            int seitenAnzahl = 6;

            wuerfel1 = new Wuerfel(seitenAnzahl);
            wuerfel1.wuerfeln();

        }

        [TestMethod]
        public void LetztesErgebnisAbrufen()
        {
            Wuerfel wuerfel1;
            int seitenAnzahl = 6;

            wuerfel1 = new Wuerfel(seitenAnzahl);
            wuerfel1.wuerfeln();

            wuerfel1.LetztesErgebnis;
        }

        [TestMethod]
        public void WuerfelSichern()
        {
            Wuerfel wuerfel1;
            int seitenAnzahl = 6;

            wuerfel1 = new Wuerfel(seitenAnzahl);
            wuerfel1.wuerfeln();

            wuerfel1.SicherungUmschalten();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void WuerfelAnlegenFehlgeschlagen()
        {
            Wuerfel wuerfel1;

            wuerfel1 = new Wuerfel(-1);

            Assert.IsTrue(wuerfel1 != null);
        }

        
    }
}