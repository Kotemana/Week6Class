using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6
{
    class Program
    {
        static void Main(string[] args)
        {
            Farm farm = new Farm();
            farm.Area = 100;
            farm.Gardenbeds = new List<GardenBed>();
            farm.Name = "Class Work";

            GardenBed pidBurachki = new GardenBed() { Area = 20, Plants = new List<Plant>() };
            Plant beetRoot = new Plant()
            {
                Name = "Burack",
                Area = 8,
                HarvestSeason = Season.Autumn,
                PlantingSeason = Season.Spring
            };

            Plant repka = new Plant()
            {
                Name = "Repa",
                Area = 11,
                HarvestSeason = Season.Autumn,
                PlantingSeason = Season.Spring
            };

            GardenBed pidBulbu = new GardenBed() { Area = 90, Plants = new List<Plant>() };
            Plant potato = new Plant()
            {
                Name = "Bulba",
                Area = 10,
                HarvestSeason = Season.Autumn,
                PlantingSeason = Season.Spring
            };
            Plant potatoSuperFast = new Plant()
            {
                Name = "Bulba skorospeyka",
                Area = 10,
                HarvestSeason = Season.Autumn,
                PlantingSeason = Season.Summer
            };
            pidBurachki.AddPlant(beetRoot);
            pidBurachki.AddPlant(repka);
            pidBulbu.AddPlant(potato);
            pidBulbu.AddPlant(potatoSuperFast);

            farm.AddGardenBed(pidBurachki);
            farm.AddGardenBed(pidBulbu);
            farm.Report();
            Console.ReadLine();
        }
    }
}
