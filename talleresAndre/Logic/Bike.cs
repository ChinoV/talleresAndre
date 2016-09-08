using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace talleresAndre.Logic
{
    class Bike: Vehicle
    {
        string cylinders { get; set; }

        public Bike(string pPlate, string pBrand, string pColor, string pCylinders)
        {
            
            this.Plate = pPlate;
            this.Brand = pBrand;
            this.Color = pColor;
            this.cylinders = pCylinders;

        }
    }
}
