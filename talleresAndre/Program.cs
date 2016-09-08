using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using talleresAndre.UI;
using talleresAndre.Logic;

namespace talleresAndre
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuUI objMenu = new MenuUI();
            Gestor objGestor = new Gestor();

            int option = objMenu.ChooseProvince();
            
        }
    }
}
