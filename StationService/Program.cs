using System;
using System.Collections.Generic;

namespace StationService
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuve cuve = new Cuve(Carburant.Diesel, 10000, 0, 150, 50, 1.34f);
            Pistolet pistolet = new Pistolet(cuve);
            List<Pistolet> pistolets = new List<Pistolet>();
            pistolets.Add(pistolet);
            Pompe pompe = new Pompe(Vehicule.Camion, pistolets);


            Console.ReadLine();
        }
    }
}
