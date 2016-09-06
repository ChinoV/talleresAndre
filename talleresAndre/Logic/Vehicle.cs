using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace talleresAndre.Logic
{
    public abstract class Vehicle
    {
        public string Plate { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public bool PowerStatus { get; set; }

        public void TurnOn()
        {
            this.PowerStatus = true;
        }

        public void TrunOff()
        {
            this.PowerStatus = false;
        }
    }
}
