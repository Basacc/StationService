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
            int nbr = rng.Next(0, 10);
            if (nbr == 5)
            {
                Panne = true;
            }
        }
    }
}
