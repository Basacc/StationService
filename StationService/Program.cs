using System;
using System.Collections.Generic;

namespace StationService
{
    class Program
    {
        static void Main(string[] args)
        {
            Pompe pompeCamion, pompeVoiture, pompeVelomoteur;
            Init(out pompeCamion, out pompeVoiture, out pompeVelomoteur);

            Console.WriteLine(pompeCamion.Approvisionner(pompeCamion.Pistolets[0], 2000));
            Console.WriteLine(pompeCamion.Approvisionner(pompeCamion.Pistolets[0], 2000));
            Console.WriteLine(pompeCamion.Approvisionner(pompeCamion.Pistolets[0], 2000));
            Console.WriteLine(pompeCamion.Approvisionner(pompeCamion.Pistolets[0], 2000));
            Console.WriteLine(pompeCamion.Approvisionner(pompeCamion.Pistolets[0], 2000));
            Console.WriteLine(pompeCamion.Approvisionner(pompeCamion.Pistolets[0], 2000));
            Console.WriteLine(pompeCamion.Approvisionner(pompeCamion.Pistolets[0], 2000));
            Console.WriteLine(pompeCamion.Approvisionner(pompeCamion.Pistolets[0], 2000));
            Console.WriteLine(pompeCamion.Approvisionner(pompeCamion.Pistolets[0], 2000));
            Console.WriteLine(pompeCamion.Approvisionner(pompeCamion.Pistolets[0], 2000));
            Console.WriteLine(pompeCamion.Approvisionner(pompeCamion.Pistolets[0], 2000));
            Console.WriteLine(pompeCamion.Approvisionner(pompeCamion.Pistolets[0], 2000));
            Console.WriteLine(pompeCamion.Approvisionner(pompeCamion.Pistolets[0], 2000));
            Console.WriteLine(pompeCamion.Approvisionner(pompeCamion.Pistolets[0], 2000));
            Console.ReadLine();
            

            void Init(out Pompe pompeCamion, out Pompe pompeVoiture, out Pompe pompeVelomoteur)
            {
                // Initialisation
                Cuve diesel = new Cuve(Carburant.Diesel, 10000, 10000, 1.52f);
                Cuve euro95 = new Cuve(Carburant.Euro95, 10000, 10000, 1.53f);
                Cuve euro98 = new Cuve(Carburant.Euro98, 10000, 10000, 1.60f);
                Cuve lpg = new Cuve(Carburant.LPG, 5000, 5000, 0.55f);
                Cuve mel2temps = new Cuve(Carburant.melange2Temps, 3000, 3000, 1.7f);

                List<Pistolet> pistoletsCamion = new List<Pistolet>();
                List<Pistolet> pistoletsVoiture = new List<Pistolet>();
                List<Pistolet> pistoletsVelomoteur = new List<Pistolet>();
                Pistolet pcd = new Pistolet(diesel);
                Pistolet pc95 = new Pistolet(euro95);
                Pistolet pc98 = new Pistolet(euro98);
                pistoletsCamion.Add(pcd);
                pistoletsCamion.Add(pc95);
                pistoletsCamion.Add(pc98);
                Pistolet pvd1 = new Pistolet(diesel);
                Pistolet pvd2 = new Pistolet(diesel);
                Pistolet pv95 = new Pistolet(euro95);
                Pistolet pv98 = new Pistolet(euro98);
                Pistolet pvlpg = new Pistolet(lpg);
                pistoletsVoiture.Add(pvd1);
                pistoletsVoiture.Add(pvd2);
                pistoletsVoiture.Add(pv95);
                pistoletsVoiture.Add(pv98);
                pistoletsVoiture.Add(pvlpg);
                Pistolet pm1 = new Pistolet(mel2temps);
                Pistolet pm2 = new Pistolet(mel2temps);
                pistoletsVelomoteur.Add(pm1);
                pistoletsVelomoteur.Add(pm2);
                pompeCamion = new Pompe(Vehicule.Camion, pistoletsCamion);
                pompeVoiture = new Pompe(Vehicule.Autres, pistoletsVoiture);
                pompeVelomoteur = new Pompe(Vehicule.Velomoteur, pistoletsVelomoteur);
            }
        }


    }
}
