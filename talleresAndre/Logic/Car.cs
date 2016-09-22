using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace talleresAndre.Logic
{
    class Car:Vehicle
    {
        string MotorCode { get; set; }

        public Car(string pPLate, string pColor, string pBrand, string pMotorCode)
        {
            this.Plate = pPLate; 
            this.Color = pColor;
            this.Brand = pBrand;
            this.MotorCode = pMotorCode;
            PowerStatus = false;
        }

        public void Move()
        {
            Console.WriteLine("The car was moved");
        }

        public string CarToString()
        {
            string CarInfo;
            string CarStatus;

            if (PowerStatus)
            {
                CarStatus = " Vehicle engine is ON";
            }
            else
            {
                CarStatus = " Vehicle engine is OFF";
            }

            CarInfo = "\nCar's License Plate: " + Plate +
                          "\nCar's Brand: " + Brand + "\nColor: " + Color +
                          "\nCar's Status: " + CarStatus;
            return CarInfo;
        }

    }
}
