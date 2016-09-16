using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace talleresAndre.UI
{
    class UI
    {
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
