using System;
using System.Collections.Generic;
using System.Text;

namespace StationService.Classes
{
    class Pistolet
    {
        Cuve cuve;
        bool panne;

        public bool Panne { get => panne; set => panne = value; }
        internal Cuve Cuve { get => cuve; set => cuve = value; }

        public Pistolet(bool panne, Cuve cuve)
        {
            Panne = panne;
            Cuve = cuve;
        }

        public void Approvisionner()
        {

        }
    }
}
