using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6
{
    public class GardenBed
    {
        public int Area { get; set; }
        public List<Plant> Plants { get; set; }

        public void AddPlant(Plant plant)
        {
            if (CheckIfLezet(plant))
            {
                Plants.Add(plant);
            }
            else
            {
                Console.WriteLine("Sorry, Your Gardenbed is not big enough");
            }
        }

        private bool CheckIfLezet(Plant plant)
        {
            int areaInUse = 0;
            foreach (var pl in Plants)
            {
                areaInUse += pl.Area;
            }
            areaInUse += plant.Area;

            return areaInUse <= Area;
        }
    }
}
