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
            Console.WriteLine("\nChoose location:\nPress 1 for Guanacaste\nPress 2 for Alajuela\nPress 3 for Heredia\nPress 4 for San Jose"
                              + "\nPress 5 for Cartago\nPress 6 for Limon\nPress 7 for Puntarenas\nPress 8 to exit program");
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
            Console.WriteLine("\nDo you want to check in a car or a bike?\nPress 1 for Car\nPress 2 to for Bike\nPress 3 to return to previous menu");
            int option;
            int.TryParse(Console.ReadKey().KeyChar.ToString(), out option);
            return option;
        }

        public List<string> RequestCarInfo()
        {
            List<string> values=new List<string>();
            Console.WriteLine("\nType in License Plate");
            values.Add(Console.ReadLine());
            Console.WriteLine("\nChoose the car's color\n1: Black \n2: Blue \n3: Gray \n4: Green \n5: Red \n6: Orange \n7: Purple \n8: Yellow \n9: White");
            values.Add(Console.ReadKey().KeyChar.ToString());
            Console.WriteLine("\nChoose the car's brand\n1: Lexus \n2: Mercedes-Benz \n3: BMW \n4: Cadillac \n5: Infiniti \n6: Lincoln \n7: Audi \n8: Ferrari  \n9: Toyota");
            values.Add(Console.ReadKey().KeyChar.ToString());
            Console.WriteLine("\nType in the car's motor Code");
            values.Add(Console.ReadLine());

            return values;
        }

        public List<string> RequestBikeInfo()
        {
            List<string> values = new List<string>();
            Console.WriteLine("\nType in License Plate");
            values.Add(Console.ReadLine());
            Console.WriteLine("\nChoose the bike's color\n1: Black \n2: Blue \n3: Gray \n4: Green \n5: Red \n6: Orange \n7: Purple \n8: Yellow \n9: White");
            values.Add(Console.ReadKey().KeyChar.ToString());
            Console.WriteLine("\nChoose the bike's brand\n1: Honda\n2: Harley-Davidson\n3: BMW\n4: Yamaha\n5: Kawasaki \n6: Suzuki\n7: KTM\n8: Triumph\n9: Ducati");
            values.Add(Console.ReadKey().KeyChar.ToString());
            Console.WriteLine("\nType in the bike's cylinders");
            values.Add(Console.ReadLine());

            return values;
        }


    }
}
