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

            //Just for day 1
            foreach (var item in mod)
            {
                var moduleFuel = (item / 3) - 2;
                //var value = Convert.ToString(moduleFuel).Substring(1,5);
                //fuelXModule.Add(Convert.ToInt32(value));
                fuelXModule.Add(moduleFuel);
            }

            int totalFuel = fuelXModule.Sum(x => Convert.ToInt32(x));

            Console.WriteLine("Day 1: Sum fuel requirements for all modules is: " + totalFuel);
            Console.ReadLine();

            var modulesTotalFuel = new List<int>();

            foreach (var item in mod)
            {
                //List to store sum of total fuel needed per module
                var singleModule = new List<int>();

                var reqFuel = new List<int>();

                for (int i = 0; i < length; i++)
                {
                    var fuelXMass = 0; //Variable initialized
                    var fuelCalc = ((item/3)-2);
                    if (fuelCalc == 0)
                    {
                        //if fuelcalc is zero then add value to the total fuel value needed (singleModule)
                        singleModule.Add(fuelCalc);
                    }
                    else
                    {
                        var rec = ((fuelCalc / 3) - 2);
                    }
                }
                
              
                
            }

            
        }
    }
}
