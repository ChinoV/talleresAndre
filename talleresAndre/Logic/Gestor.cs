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

        public void DisplayText()
        {
            Console.WriteLine(CurrentCarShop.CarShopToString());
        }

        public Gestor()
        {
            this.CarShops = new List<CarShop>();
        }

        public int AsignProvince(int option)
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
            CurrentProvince = province;
            return option;
        }

        public void SetCurrentProvince(string pProvince)
        {
            CurrentProvince = pProvince; 
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
            CarShop objCarShopasd = new CarShop("Guanacaste", RandomIntGenerator());
            objCarShopasd.Id = ++countShops;
            CarShop objCarShop1a = new CarShop("Guanacaste", RandomIntGenerator());
            objCarShop1a.Id = ++countShops;

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
            CarShops.Add(objCarShopasd);
            CarShops.Add(objCarShop1a);
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

        public void DisplayCarShopsByProvince(string pProvince)
        {
            string x = "";
            foreach (CarShop CarShop in CarShops)
            {
                if (pProvince == CarShop.Province)
                {
                    x+= "\nCarShop Id: "+CarShop.Id; 
                }
            }
            Console.WriteLine(x);
        }

        //public CarShop CarShopsById()
        //{

        //}

        public bool CarRegistration(CarShop pCarShop, List<string>values)
        {
            int x;
            int.TryParse(values[1], out x);
            
            switch (x)
            {
                case 1:
                    values[1] = "Black";
                    break;
                case 2:
                    values[1] = "Blue";
                    break;
                case 3:
                    values[1] = "Gray";
                    break;
                case 4:
                    values[1] = "Green";
                    break;
                case 5:
                    values[1] = "Red";
                    break;
                case 6:
                    values[1] = "Orange";
                    break;
                case 7:
                    values[1] = "Purple";
                    break;
                case 8:
                    values[1] = "Yellow";
                    break;
                case 9:
                    values[1] = "White";
                    break; 
                default:
                    values[1] = "";
                    break;
            }
            switch (int.Parse(values[2]))
            {
                case 1:
                    values[2] = "Lexus";
                    break;
                case 2:
                    values[2] = "Mercedes-Benz";
                    break;
                case 3:
                    values[2] = "BMW";
                    break;
                case 4:
                    values[2] = "Cadillac";
                    break;
                case 5:
                    values[2] = "Infiniti";
                    break;
                case 6:
                    values[2] = "Lincoln";
                    break;
                case 7:
                    values[2] = "Audi";
                    break;
                case 8:
                    values[2] = "Ferrari ";
                    break;
                case 9:
                    values[2] = "Toyota";
                    break;
                default:
                    values[2] = "";
                    break;
            }

            if (values[1] != ""&& values[2] != "")
            {
                if (pCarShop.RegisterCar(values))
                {
                    return true;
                }
            }
            return false;
        }
        public bool BikeRegistration(CarShop pCarShop, List<string> values)
        {
            switch (int.Parse(values[1]))
            {
                case 1:
                    values[1] = "Black";
                    break;
                case 2:
                    values[1] = "Blue";
                    break;
                case 3:
                    values[1] = "Gray";
                    break;
                case 4:
                    values[1] = "Green";
                    break;
                case 5:
                    values[1] = "Red";
                    break;
                case 6:
                    values[1] = "Orange";
                    break;
                case 7:
                    values[1] = "Purple";
                    break;
                case 8:
                    values[1] = "Yellow";
                    break;
                case 9:
                    values[1] = "White";
                    break;
                default:
                    values[1] = "";
                    break;
            }
            switch (int.Parse(values[2]))
            {
                case 1:
                    values[2] = "Honda";
                    break;
                case 2:
                    values[2] = "Harley-Davidson";
                    break;
                case 3:
                    values[2] = "BMW";
                    break;
                case 4:
                    values[2] = "Yamaha";
                    break;
                case 5:
                    values[2] = "Kawasaki";
                    break;
                case 6:
                    values[2] = "Suzuki";
                    break;
                case 7:
                    values[2] = "KTM";
                    break;
                case 8:
                    values[2] = "Triumph ";
                    break;
                case 9:
                    values[2] = "Ducati";
                    break;
                default:
                    values[2] = "";
                    break;
            }

            if (values[1] != "" && values[2] != "")
            {
                if (pCarShop.RegisterBike(values))
                {
                    return true;
                }
            }
            return false;
        }

        public int RandomIntGenerator()
        {
            Random r = new Random();
            int rInt = r.Next(5, 25);
            return rInt;
        }
    }
}
