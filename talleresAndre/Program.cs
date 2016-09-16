using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using talleresAndre.Logic;
using talleresAndre.UI;

namespace talleresAndre
{
    class Program
    {
        static void Main(string[] args)
        {

            Gestor objGestor = new Gestor();
            MenuUI Menu = new MenuUI();
            //objGestor.LoadoutCarshops();

            List<int> Capacity = new List<int>();
            int x = 1;
            if (Capacity.Count <= 2)
            {
                Capacity.Add(x++);
            }

            do
            {
                objGestor.SetCurrentProvince(objGestor.AsignProvince(Menu.ChooseProvince()));
                if (objGestor.CurrentProvince != "")
                {
                    if (objGestor.CarShopsByProvince(objGestor.CurrentProvince) == null)
                    {
                        Console.WriteLine("\nNo Car Shop found in that area, a new one has been created to take care of your vehicle");
                        objGestor.SetCurrentCarShop(objGestor.CreateOneCarShop(objGestor.CurrentProvince, objGestor.RandomIntGenerator()));
                        //a car shop has been created, car or bike? - request vehicle info - insert that vehicle in the CarShop
                    }
                    else
                    {
                        switch((Menu.CurrentOrNewCarShop()))
                        {
                            case 1:
                                if (Menu.CarOrBike()== 1)
                                {
                                    //objGestor.CarRegistration(Menu.RequestCarInfo());
                                }
                                break;

                            case 2:
                                break;

                            default:
                                break;
                        }
                        
                    }
                }
                else
                {
                    Console.WriteLine("\nInvalid option, must chose only one number between 1 and 7");
                }
            } while (objGestor.CurrentProvince == "");
            
             
            Console.ReadKey();
        }
    }
}
