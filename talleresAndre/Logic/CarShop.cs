﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace talleresAndre.Logic
{
    public class CarShop
    {
        public int Id { get; set; }
        public string Province { get; set; }
        public List<Vehicle> VehicleList { get; set; }
        public List<Receipt> Bills { get; set; }
        private int Capacity { get; set; }

        public CarShop(string pProvince, int pCapacity)
        {
            this.Province = pProvince;
            this.VehicleList = new List<Vehicle>();
            this.Capacity = pCapacity;
        }

        public int GetEmptySlot(int begin, int end)
        {
            for (int i = begin; i <= end; i++)
            {
                if (VehicleList[i] == null)
                {
                    return i;
                }
            }
            return -1;
        }

        public void RegisterCar(List<string>Values)
        {
            if (this.VehicleList.Count() < VehicleList.Capacity)
            {
                Car objCar = new Car(Values[0], Values[1], Values[2], int.Parse(Values[3]));
                this.VehicleList.Add(objCar);
            }
            
        }

        public void RegisterBike(List<string> Values)
        {
            if (this.VehicleList.Count() < VehicleList.Capacity)
            {
                Bike objBike = new Bike(Values[0], Values[1], Values[2], Values[3]);
                this.VehicleList.Add(objBike);
            }
        }

        public void AnalyzeVehicle(Vehicle objVehicle)
        {
            Console.WriteLine("The vehicle with license plate "+objVehicle.Plate+ " has been analized");
        }

        public void Repair(Vehicle objVehicle)
        {
            Console.WriteLine("The vehicle with license plate " +objVehicle.Plate+ " has been repaired");
        }

        public void TakePayment()
        {

        }

        public void Return()
        {

            //search array by plate and delete
        }

        public bool InsertVehicle(Vehicle y, int option)
        {
            int slot = -1;
            switch (option)
            {
                case 1:
                    slot = GetEmptySlot(0, 3);

                    break;
                case 2:
                    slot = GetEmptySlot(4, 8);

                    break;
            }

            if (slot != -1)
            {
                VehicleList[slot] = y;
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
