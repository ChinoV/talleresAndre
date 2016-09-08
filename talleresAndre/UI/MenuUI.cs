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
    }
}
