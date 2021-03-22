using System;
using System.Collections.Generic;
using System.Text;

namespace StationService.Classes
{
    class Cuve
    {
        string typeCarburant;
        float contenanceMax;
        float contenance;
        float seuilRemplissage;
        float seuilApprovisionnement;
        bool problemeDistribution;
        bool enCoursDeRemplissage;

        public string TypeCarburant { get => typeCarburant; set => typeCarburant = value; }
        public float ContenanceMax { get => contenanceMax; set => contenanceMax = value; }
        public float Contenance { get => contenance; set => contenance = value; }
        public float SeuilRemplissage { get => seuilRemplissage; set => seuilRemplissage = value; }
        public float SeuilApprovisionnement { get => seuilApprovisionnement; set => seuilApprovisionnement = value; }
        public bool ProblemeDistribution { get => problemeDistribution; set => problemeDistribution = value; }
        public bool EnCoursDeRemplissage { get => enCoursDeRemplissage; set => enCoursDeRemplissage = value; }

        public Cuve(string typeCarburant, float contenanceMax, float contenance, float seuilRemplissage, float seuilApprovisionnement)
        {
            TypeCarburant = typeCarburant;
            ContenanceMax = contenanceMax;
            Contenance = contenance;
            SeuilRemplissage = seuilRemplissage;
            SeuilApprovisionnement = seuilApprovisionnement;
        }

        public void CommanderCarburant()
        {

        }
    }
}
