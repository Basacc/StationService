using System;
using System.Collections.Generic;
using System.Text;

namespace StationService.Classes
{
    class Pompe
    {
        string typeVehicule;
        List<Pistolet> pistolets;
        bool panne;

        public string TypeVehicule { get => typeVehicule; set => typeVehicule = value; }
        public bool Panne { get => panne; set => panne = value; }
        internal List<Pistolet> Pistolets { get => pistolets; set => pistolets = value; }

        public Pompe(string typeVehicule, bool panne, List<Pistolet> pistolets)
        {
            TypeVehicule = typeVehicule;
            Panne = panne;
            Pistolets = pistolets;
        }
    }
}
