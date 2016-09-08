using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace talleresAndre.Logic
{
    class CarShop
    {
        int Id { get; set; }
        string Province { get; set; }
        Vehicle[]Capacity { get; set; }
        public List<Receipt> Bills { get; set; }

        public CarShop(int pId, string pProvince, int pCapacity)
        {
            this.Id = pId;
            this.Province = pProvince;
            this.Capacity=new Vehicle[pCapacity];
        }

        public int GetEmptySlot(int begin, int end)
        {
            for (int i = begin; i <= end; i++)
            {
                if (Capacity[i] == null)
                {
                    return i;
                }
            }

            return -1;
        }

        public void RegisterVehicle(int slot, Vehicle pVehicle)
        {
            if (slot!=-1)
            {
                Capacity[slot] = pVehicle;
            }
        }

        public void AnalyzeVehicle()
        {
            Console.WriteLine("the vehicle has been analized");
        }

        public void Repair()
        {
            Console.WriteLine("the vehicle has been repaired");
        }

        public void TakePayment()
        {

        }

        public void Return()
        {

        }

    }
}
