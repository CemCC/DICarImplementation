using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiCarImplementation
{
    class Production
    {
      
        public void ColourChange(InterfaceCar car, string colour) => car.colour = colour;
        public void ModelChange(InterfaceCar car, string model) => car.model = model;
        public void WheelChange(InterfaceCar car, int tyrecount) => car.tyreCount = tyrecount;

        public string CarFeatures(InterfaceCar car) {

            var arry = new string[4];

            arry[0] = $"{nameof(car.tyreCount)}:{car.tyreCount}";
            arry[1] = $"{nameof(car.colour)}:{car.colour}";
            arry[2] = $"{nameof(car.model)}:{car.model}";
            arry[3] = $"{nameof(car.brand)}:{car.brand}";

            return string.Join(Environment.NewLine, arry);

        }
    }
}
