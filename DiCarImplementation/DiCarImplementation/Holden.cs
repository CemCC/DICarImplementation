using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiCarImplementation
{
    class Holden : InterfaceCar
    {
        public Holden(string _brand, string _model, string _colour, int _tyrecount)
        {

            tyreCount = _tyrecount;
            colour = _colour; ;
            model = _model;
            brand = _brand;
            
        }

        public int tyreCount { get; set; }
        public string colour { get; set; }
        public string model { get; set; }
        public string brand { get; set; }
    }
}
