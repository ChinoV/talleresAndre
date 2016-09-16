using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace talleresAndre.Logic
{
    class Car:Vehicle
    {
        int MotorCode { get; set; }

        public Car(string pPLate, string pBrand, string pColor, int pMotorCode)
        {
            this.Plate = pPLate;
            this.Brand = pBrand;
            this.Color = pColor;
            this.MotorCode = pMotorCode;
            PowerStatus = false;
        }

        public void Move()
        {
            Console.WriteLine("The car was moved");
        }
    }
}
