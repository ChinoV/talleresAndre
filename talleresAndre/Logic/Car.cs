using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace talleresAndre.Logic
{
    class Car: Vehicle
    {
        int MotorId { get; set; }

        public Car(string pPlate, string pBrand, string pColor, int pMotorId)
        {

            this.Plate = pPlate;
            this.Brand = pBrand;
            this.Color = pColor;
            this.MotorId = pMotorId; 
        }

        public void Move()
        {
            Console.WriteLine("Car was Moved");
        }
    }
}
