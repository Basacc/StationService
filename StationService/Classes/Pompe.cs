using System;
using System.Collections.Generic;
using System.Text;

namespace StationService
{
    enum Vehicule { Velomoteur, Camion, Autres}
    class Pompe : Reparation
    {
        Vehicule vehicule;
        List<Pistolet> pistolets;
        bool panne;

        public bool Panne { get => panne; set => panne = value; }
        internal List<Pistolet> Pistolets { get => pistolets; set => pistolets = value; }
        internal Vehicule Vehicule { get => vehicule; set => vehicule = value; }

        public Pompe(Vehicule vehicule, List<Pistolet> pistolets)
        {
            Vehicule = vehicule;
            Pistolets = pistolets;
        }

        public float Approvisionner(Pistolet pistolet, float quantite)
        {
            if (pistolet.Cuve.EnCoursDeRemplissage)
            {
                Console.WriteLine("Cuve en cours de remplissage, réessayez plus tard...");
                pistolet.Cuve.EnCoursDeRemplissage = false;
                return 0;
            }
            pistolet.TomberEnPanne();
            pistolet.Cuve.TomberEnPanne();
            TomberEnPanne();

            if (pistolet.Cuve.Contenance > pistolet.Cuve.SeuilApprovisionnement && quantite < pistolet.Cuve.Contenance 
                && pistolet.Cuve.EnCoursDeRemplissage == false && pistolet.Cuve.ProblemeDistribution == false && Panne == false)
            {
                pistolet.Cuve.Contenance -= quantite;
                float prix = pistolet.Cuve.PrixCarburant * quantite;
                if (pistolet.Cuve.Contenance <= pistolet.Cuve.SeuilRemplissage)
                {
                    pistolet.Cuve.CommanderCarburant();
                }
                return prix;
            }
            Console.WriteLine("Hors service");
            pistolet.Reparer();
            this.Reparer();
            pistolet.Cuve.Reparer();
            return 0;
        }

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
            int nbr = rng.Next(0, 30);
            if (nbr == 5)
            {
                Panne = true;
            }
        }
    }
}
