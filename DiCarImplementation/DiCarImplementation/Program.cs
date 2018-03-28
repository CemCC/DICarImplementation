using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiCarImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            var productionManagement = new Production
            {
               car = new Holden("Holden", "commodore", "Red", 4)
            }; 

            Console.WriteLine(productionManagement.CarFeatures());
            Console.WriteLine();
            //Console.ReadLine();

            productionManagement.ColourChange("Blue");
            productionManagement.ModelChange("newHolden");
            productionManagement.WheelChange(3);

            Console.WriteLine(productionManagement.CarFeatures() +" "+"Newly Produced");
            Console.ReadLine();
            

        }
    }
}
