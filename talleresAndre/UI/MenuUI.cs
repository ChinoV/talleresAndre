using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace talleresAndre.UI
{
    class MenuUI
    {
        public int ChooseProvince()
        {
            Console.WriteLine("Press 1 for Guanacaste\nPress 2 for Alajuela\nPress 3 for Heredia\nPress 4 for San Jose"
                              + "\nPress 5 for Cartago\nPress 6 for Limon\nPress 7 for Puntarenas");
            int option;
            int.TryParse(Console.ReadKey().KeyChar.ToString(), out option);
            return option;
        }

        public int ChooseVehicleType()
        {
            Console.WriteLine("Press 1 for car\nPress 2 for Bike");
            int option;
            int.TryParse(Console.ReadKey().KeyChar.ToString(), out option);
            return option;
        }

        public int CurrentOrNewCarShop()
        {
            Console.WriteLine("\nPress 1 to use current Car Shop\nPress 2 to create a new Car Shop");
            int option;
            int.TryParse(Console.ReadKey().KeyChar.ToString(), out option);
            return option;
        }

        public int CarOrBike()
        {
            Console.WriteLine("\nDo you want to check in a car or a bike?\nPress 1 for Car\nPress 2 to for Bike");
            int option;
            int.TryParse(Console.ReadKey().KeyChar.ToString(), out option);
            return option;
        }

        public List<string> RequestCarInfo()
        {
            List<string> values=new List<string>();
            Console.WriteLine("Type in License Plate");
            values.Add(Console.ReadLine());
            Console.WriteLine("Type in the car's brand");
            values.Add(Console.ReadLine());
            Console.WriteLine("Type in the car's color");
            values.Add(Console.ReadLine());
            Console.WriteLine("Type in the car's motor Code");
            values.Add(Console.ReadLine());

            return values;
        }

        public List<string> RequestBikeInfo()
        {
            List<string> values = new List<string>();
            Console.WriteLine("Type in License Plate");
            values.Add(Console.ReadLine());
            Console.WriteLine("Type in the bike's brand");
            values.Add(Console.ReadLine());
            Console.WriteLine("Type in the bike's color");
            values.Add(Console.ReadLine());
            Console.WriteLine("Type in the bike's cylinders");
            values.Add(Console.ReadLine());

            return values;
        }


    }
}
