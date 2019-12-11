using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Modules modules = new Modules();
            var mod = modules.SpaceCraftModules();

            var fuelXModule = new List<int>();

            foreach (var item in mod)
            {
                var moduleFuel = (item / 3) - 2;
                //var value = Convert.ToString(moduleFuel).Substring(1,5);
                //fuelXModule.Add(Convert.ToInt32(value));
                fuelXModule.Add(moduleFuel);
            }

            foreach (var item in mod)
            {
                var moduleFuel = (item / 3) - 2;

                for (int i = 0; moduleFuel != 0; i++)
                {

                }
                
            }

            int totalFuel = fuelXModule.Sum(x => Convert.ToInt32(x));

            Console.WriteLine("Day 1: Sum fuel requirements for all modules is: " + totalFuel);
            Console.ReadLine();
        }
    }
}
