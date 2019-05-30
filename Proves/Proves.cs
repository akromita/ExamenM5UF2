using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Llibreria;

namespace Proves
{
    [TestClass]
    public class Proves
    {
        
        [TestMethod]
        public void EsPrimer()
        {
            Boolean resultat;
            ClEncriptar clE = new ClEncriptar();
            resultat = clE.EsPrimer(7);
            Console.WriteLine("Resultado: " + resultat);
            Assert.AreEqual(true, resultat);
        }

        [TestMethod]
        public void EsMesGran()
        {
            Int32 resultat;
            ClEncriptar clE = new ClEncriptar();
            resultat = clE.EsMesGran(24, 22);
            Console.WriteLine("Resultado: " + resultat);
            Assert.AreEqual(24, resultat);
        }

        [TestMethod]
        public void EsMesPetit()
        {
            Int32 resultat;
            ClEncriptar clE = new ClEncriptar();
            resultat = clE.EsMesPetit(17, 15);
            Console.WriteLine("Resultado: " + resultat);
            Assert.AreEqual(15, resultat);
        }

        [TestMethod]
        public void Divisors()
        {
            String resultat;
            ClEncriptar clE = new ClEncriptar();
            resultat = clE.Divisors(4);
            Console.WriteLine("Resultado:" + resultat);
            Assert.AreEqual("0,1,2,4", resultat);
        }

    }
}
