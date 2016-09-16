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

        public Bike(string pPLate, string pBrand, string pColor, string pCylinders)
        {
            this.Plate = pPLate;
            this.Brand = pBrand;
            this.Color = pColor;
            this.Cylinders = pCylinders;
            PowerStatus = false;
        }
    }
}
