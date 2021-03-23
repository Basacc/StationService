using System;
using System.Collections.Generic;
using System.Text;

namespace StationService
{
    enum Carburant
    {
        LPG, Euro95, Euro98, Diesel, melange2Temps
    }
    class Cuve : Reparation
    {
        float contenanceMax;
        float contenance;
        float seuilRemplissage;
        float seuilApprovisionnement;
        float prixCarburant;
        bool problemeDistribution;
        bool enCoursDeRemplissage;
        Carburant carburant;

        public float ContenanceMax { get => contenanceMax; set => contenanceMax = value; }
        public float Contenance { get => contenance; set => contenance = value; }
        public float SeuilRemplissage { get => seuilRemplissage; private set => seuilRemplissage = value; }
        public float SeuilApprovisionnement { get => seuilApprovisionnement; private set => seuilApprovisionnement = value; }
        public bool ProblemeDistribution { get => problemeDistribution; set => problemeDistribution = value; }
        public bool EnCoursDeRemplissage { get => enCoursDeRemplissage; set => enCoursDeRemplissage = value; }
        public float PrixCarburant { get => prixCarburant; set => prixCarburant = value; }
        internal Carburant Carburant { get => carburant; set => carburant = value; }

        public Cuve(Carburant carburant, float contenanceMax, float contenance, float prixCarburant)
        {
            Carburant = carburant;
            ContenanceMax = contenanceMax;
            Contenance = contenance;
            SeuilRemplissage = ContenanceMax * 0.1f;
            SeuilApprovisionnement = ContenanceMax * 0.05f;
            PrixCarburant = prixCarburant;
        }

        public void CommanderCarburant()
        {
            if (Contenance <= SeuilRemplissage)
            {
                EnCoursDeRemplissage = true;
                Contenance = ContenanceMax;
            }
        }

        public void Reparer()
        {
            if (ProblemeDistribution == true)
            {
                ProblemeDistribution = false;
            }
        }

        public void TomberEnPanne()
        {
            Random rng = new Random();
            int nbr = rng.Next(0, 10);
            if (nbr == 5)
            {
                ProblemeDistribution = true;
            }
        }
    }
}
