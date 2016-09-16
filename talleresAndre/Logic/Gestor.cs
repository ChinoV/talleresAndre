using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace talleresAndre.Logic
{
    class Gestor
    {

        private List<CarShop> CarShops { get; set; }
        public string CurrentProvince;
        public CarShop CurrentCarShop { get; set; }
         
        public Gestor()
        {
            this.CarShops = new List<CarShop>();
        }

        public string AsignProvince(int option)
        {
            string province;
            switch (option)
            {
                case 1:
                    province = "Guanacaste";
                    break;
                case 2:
                    province = "Alajuela";
                    break;
                case 3:
                    province = "Heredia";
                    break;
                case 4:
                    province = "San Jose";
                    break;
                case 5:
                    province = "Cartago";
                    break;
                case 6:
                    province = "Limon";
                    break;
                case 7:
                    province = "Puntarenas";
                    break;

                default:
                    province = "";
                    break;
            }
            return province;
        }

        public string SetCurrentProvince(string pProvince)
        {
            CurrentProvince = pProvince;
            return CurrentProvince;
        }

        public CarShop SetCurrentCarShop(CarShop pCarShop)
        {
            CurrentCarShop = pCarShop;
            return CurrentCarShop;
        }

        public CarShop CreateOneCarShop(string pProvince, int pCapacity)
        {
            int countShops = CarShops.Count;
            CarShop objCarShop = new CarShop(pProvince, pCapacity);
            objCarShop.Id = ++countShops;
            CarShops.Add(objCarShop);
            return objCarShop;
        }

        public void LoadoutCarshops()
        {
            int countShops = CarShops.Count;
            CarShop objCarShop1 = new CarShop("Guanacaste", RandomIntGenerator());
            objCarShop1.Id = ++countShops;
            
            CarShop objCarShop2 = new CarShop("Alajuela", RandomIntGenerator());
            objCarShop2.Id = ++countShops;
            
            CarShop objCarShop3 = new CarShop("Heredia", RandomIntGenerator());
            objCarShop3.Id = ++countShops;
            
            CarShop objCarShop4 = new CarShop("San Jose", RandomIntGenerator());
            objCarShop4.Id = ++countShops;
            
            CarShop objCarShop5 = new CarShop("Cartago", RandomIntGenerator());
            objCarShop5.Id = ++countShops;
            
            CarShop objCarShop6 = new CarShop("Limon", RandomIntGenerator());
            objCarShop6.Id = ++countShops;
            
            CarShop objCarShop7 = new CarShop("Puntarenas", RandomIntGenerator());
            objCarShop7.Id = ++countShops;

            CarShops.Add(objCarShop1);
            CarShops.Add(objCarShop2);
            CarShops.Add(objCarShop3);
            CarShops.Add(objCarShop4);
            CarShops.Add(objCarShop5);
            CarShops.Add(objCarShop6);
            CarShops.Add(objCarShop7);
        }

        public CarShop CarShopsByProvince(string pProvince)
        {
            foreach (CarShop CarShop in CarShops)
            {
                if (pProvince == CarShop.Province)
                {
                    return CarShop;
                }
            }
            return null;
        }

        //public CarShop CarShopsById()
        //{

        //}


        public void CarRegistration(CarShop pCarShop, List<string>values)
        {
            pCarShop.RegisterCar(values);
        }

        public int RandomIntGenerator()
        {
            Random r = new Random();
            int rInt = r.Next(5, 25);
            return rInt;
        }
    }
}
