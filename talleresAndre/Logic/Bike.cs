using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace talleresAndre.Logic
{
    class Bike:Vehicle
    {
        string Cylinders { get; set; }

        public Bike(string pPLate, string pColor, string pBrand, string pCylinders)
        {
            this.Plate = pPLate;
            this.Color = pColor;
            this.Brand = pBrand;
            this.Cylinders = pCylinders;
            PowerStatus = false;
        }
    }
}
