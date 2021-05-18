using System;
using System.Collections.Generic;
using System.Text;

namespace StationService
{
    class Pistolet : Reparation
    {
        Cuve cuve;
        bool panne;

        public bool Panne { get => panne; set => panne = value; }
        internal Cuve Cuve { get => cuve; set => cuve = value; }

        public Pistolet(Cuve cuve)
        {
            Cuve = cuve;
        }

        //public float Approvisionner(float quantite)
        //{
        //    if (cuve.EnCoursDeRemplissage)
        //    {
        //        Console.WriteLine("Cuve en cours de remplissage, réessayez plus tard...");
        //        cuve.EnCoursDeRemplissage = false;
        //        return 0;
        //    }

        //    Cuve.TomberEnPanne();
        //    TomberEnPanne();

        //    if (cuve.Contenance > cuve.SeuilApprovisionnement && quantite < cuve.Contenance && cuve.EnCoursDeRemplissage == false 
        //        && cuve.ProblemeDistribution == false  && Panne == false)
        //    {
        //        cuve.Contenance -= quantite;
        //        float prix = cuve.PrixCarburant * quantite;
        //        if (cuve.Contenance <= cuve.SeuilRemplissage)
        //        {
        //            cuve.CommanderCarburant();
        //        }
        //        return prix;
        //    }
        //    Console.WriteLine("Hors service");
        //    Reparer();
        //    Cuve.Reparer();
        //    return 0;
        //}

        public void Reparer()
        {
            if (Panne == true)
            {
                Panne = false;
            }
        }

        public void TomberEnPanne()
        {
            Random rng = new Random();
            int nbr = rng.Next(0, 20);
            if (nbr == 5)
            {
                Panne = true;
            }
        }
    }
}
