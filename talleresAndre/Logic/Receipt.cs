using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace talleresAndre.Logic
{
    class Receipt
    {
        public string CarShopName { get; set; }
        public DateTime PayDate { get; set; }
        public List<Vehicle> Vehicles { get; set; }
        public double TotalCost { get; set; }

        public Receipt()
        {

        }

    }
}
