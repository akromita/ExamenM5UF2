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
      
    }
}
