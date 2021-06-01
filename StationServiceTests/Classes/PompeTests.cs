using Microsoft.VisualStudio.TestTools.UnitTesting;
using StationService;
using System;
using System.Collections.Generic;
using System.Text;

namespace StationService.Tests
{
    [TestClass()]
    public class PompeTests
    {
        [TestMethod()]
        public void ApprovisionnerTest()
        {
            //initialisation
            float contenance = 5000;
            float retrait = 1000;
            float contenanceFinale = 4000;
            int prixTest = 1;
            float prixSuppose = retrait * prixTest;
            Cuve cuve = new Cuve(Carburant.Diesel, 10000, contenance, prixTest);
            Pistolet pistolet = new Pistolet(cuve);
            List<Pistolet> list = new List<Pistolet>();
            list.Add(pistolet);
            Pompe pompe = new Pompe(Vehicule.Autres, list);

            //approvisionnement 
            float prixReel = pompe.Approvisionner(pistolet, retrait);

            //assert
            //Note : le test peut echouer suite à une panne aleatoire de la pompe, pistolet ou cuve.
            //       Plusieurs executions necessaires
            Assert.AreEqual(contenanceFinale, cuve.Contenance);
            Assert.AreEqual(prixSuppose, prixReel);

        }

    }
}