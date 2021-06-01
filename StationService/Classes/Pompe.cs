using System;
using System.Collections.Generic;
using System.Text;

namespace StationService
{
    public enum Vehicule { Velomoteur, Camion, Autres}
    public class Pompe : Reparation
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
            //Retire si possible une quantité de carburant de la cuve via un pistolet et retourne le prix
            if (pistolet.Cuve.EnCoursDeRemplissage)
            {
                Console.WriteLine("Cuve en cours de remplissage, réessayez plus tard...");
                pistolet.Cuve.EnCoursDeRemplissage = false;
                return 0;
            }
            pistolet.TomberEnPanne();
            pistolet.Cuve.TomberEnPanne();
            TomberEnPanne();

            if (pistolet.Cuve.ProblemeDistribution == false && Panne == false && pistolet.Panne == false)
            {
                if (pistolet.Cuve.Contenance <= pistolet.Cuve.SeuilRemplissage)
                {
                    pistolet.Cuve.CommanderCarburant();
                }
                if (quantite > pistolet.Cuve.Contenance - pistolet.Cuve.SeuilApprovisionnement)
                {
                    Console.WriteLine("Quantité sélectionnée trop élevée");
                    pistolet.Cuve.CommanderCarburant();
                    return 0;
                }
                pistolet.Cuve.Contenance -= quantite;
                float prix = pistolet.Cuve.PrixCarburant * quantite;
                return prix;
            }
            if (pistolet.Panne)
            {
                pistolet.Reparer();
                Console.WriteLine("Pistolet hors service");
            }
            if (pistolet.Cuve.ProblemeDistribution)
            {
                pistolet.Cuve.Reparer();
                Console.WriteLine("Cuve hors service");
            }
            if (this.Panne)
            {
                this.Reparer();
                Console.WriteLine("Pompe hors service");
            }
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
            // la pompe tombe en panne de manière aléatoire
            Random rng = new Random();
            int nbr = rng.Next(0, 30);
            if (nbr == 5)
            {
                Panne = true;
            }
        }
    }
}
