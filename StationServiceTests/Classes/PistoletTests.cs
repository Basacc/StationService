using Microsoft.VisualStudio.TestTools.UnitTesting;
using StationService;
using System;
using System.Collections.Generic;
using System.Text;

namespace StationService.Tests
{
    [TestClass()]
    public class PistoletTests
    {
        [TestMethod()]
        public void TomberEnPanneTest()
        {
            // initialisation
            Cuve cuve = new Cuve(Carburant.Euro95, 10000, 10000, 1);
            Pistolet p = new Pistolet(cuve);
            
            //test
            do
            {
                p.TomberEnPanne();
            } while (!p.Panne);

            //assert
            Assert.IsTrue(p.Panne);
        }
    }
}