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

        
        public void Reparer()
        {
            if (Panne == true)
            {
                Panne = false;
            }
        }

        public void TomberEnPanne()
        {
            // le pistolet tombe en panne aléatoirement
            Random rng = new Random();
            int nbr = rng.Next(0, 20);
            if (nbr == 5)
            {
                Panne = true;
            }
        }
    }
}
