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
            var productionManagement = new Production();
            var car = new Toyota("toyota", "Corolla", "White", 4);
            Console.WriteLine(productionManagement.CarFeatures(car));
            Console.WriteLine();
            //Console.ReadLine();

            productionManagement.ColourChange(car,"Blue");
            productionManagement.ModelChange(car,"newToyota");
            productionManagement.WheelChange(car, 3);

            Console.WriteLine(productionManagement.CarFeatures(car) +" "+"Newly Produced");
            Console.ReadLine();
            

        }
    }
}
