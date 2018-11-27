using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6
{
    public class Farm
    {
        public int Area { get; set; }
        public string Name { get; set; }
        public List<GardenBed> Gardenbeds { get; set; }

        public void Report()
        {
            Console.WriteLine($"This is farm {Name} with area {Area} sq. km");
            Console.WriteLine($"Farm has {Gardenbeds.Count} gardenbeds");
            for (int i = 0; i < Gardenbeds.Count; i++)
            {
                Console.WriteLine($"Gardenbed has {Gardenbeds[i].Plants.Count} plants:");
                for (int j = 0; j < Gardenbeds[i].Plants.Count; j++)
                {
                    Console.WriteLine($"{Gardenbeds[i].Plants[j].Name} planted in {Gardenbeds[i].Plants[j].PlantingSeason} and harvested in {Gardenbeds[i].Plants[j].HarvestSeason} uses {Gardenbeds[i].Plants[j].Area} sq. km");
                }
            }

            //foreach (var gb in Gardenbeds)
            //{
            //    Console.WriteLine($"Gardenbed has {gb.Plants.Count} plants:");
            //    foreach (var plant in gb.Plants)
            //    {
            //        Console.WriteLine($"{plant.Name} planted in {plant.PlantingSeason} and harvested in {plant.HarvestSeason} uses {plant.Area} sq. km");
            //    }
            //}
        }

        public void AddGardenBed(GardenBed gardenBed)
        {
            bool canBeAdded = CheckIfLezet(gardenBed);
            if (canBeAdded)
            {
                Gardenbeds.Add(gardenBed);
            }
            else
            {
                Console.WriteLine("Sorry, Your farm is not big enough");
            }
        }

        private bool CheckIfLezet(GardenBed gardenBed)
        {
            int areaInUse = 0;
            foreach (var gb in Gardenbeds)
            {
                areaInUse += gb.Area;
            }
            areaInUse += gardenBed.Area;
            if(areaInUse <= Area)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
