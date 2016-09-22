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
            MenuUI objMenu = new MenuUI();
            objGestor.LoadoutCarshops();
            int option=0;
            //while (option < 30000)
            //{
            //    option++;
            //    Console.WriteLine("Searching for files: CaseLaw\nUpdating DataBase\nUpdating...\nUse of selected-text mappings defined in TCHAR.H\nUpdating...\nUpdating folders...\nUpdating..\nFiltering by date..\nDeleting discarded files");
            //    Console.WriteLine("Updating...\nUpdating...\nUpdating folders...\nUpdating...\nFiltering by date..\nDeleting discarded files\nC:/Users/Personal/Desktop/LDvirtual");
            //    Console.WriteLine("Searching for files: CaseLaw\nUpdating DataBase\nUpdating...\nUse of selected-text mappings defined in TCHAR.H\nUpdating...\n#include <stdio.h>\n#include <stdlib.h>\n#include <string.h>#include <direct.h>");
            //}
            do
            {
                option=objGestor.AsignProvince(objMenu.ChooseProvince());
                if (objGestor.CurrentProvince != "")
                {
                    if (objGestor.CarShopsByProvince(objGestor.CurrentProvince) == null)
                    {
                        Console.WriteLine("\nNo Car Shop found in that area, a new one has been created to take care of your vehicle");
                        objGestor.SetCurrentCarShop(objGestor.CreateOneCarShop(objGestor.CurrentProvince, objGestor.RandomIntGenerator()));

                        do
                        {
                            option = objMenu.CarOrBike();
                            if (option != 3)
                            {
                                switch (option)
                                {
                                    case 1:
                                        CarMethod(objGestor, objMenu);
                                        objGestor.DisplayText();
                                        break;

                                    case 2:
                                        BikeMethod(objGestor, objMenu);
                                        objGestor.DisplayText();
                                        break;

                                    default:
                                        Console.WriteLine("\nWrong input, must press 1, 2 or 3");
                                        break;
                                }
                            }
                        } while (option > 3|| option==0);
                    }
                    else
                    {
                        objGestor.DisplayCarShopsByProvince(objGestor.CurrentProvince);
                        switch ((objMenu.CurrentOrNewCarShop()))
                        {
                            case 1:
                                objGestor.SetCurrentCarShop(objGestor.CarShopsByProvince(objGestor.CurrentProvince));
                                do
                                {
                                    option = objMenu.CarOrBike();
                                    if (option != 3)
                                    {
                                        switch (option)
                                        {
                                            case 1:
                                                CarMethod(objGestor, objMenu);
                                                objGestor.DisplayText();
                                                break;

                                            case 2:
                                                BikeMethod(objGestor, objMenu);
                                                objGestor.DisplayText();
                                                break;

                                            default:
                                                Console.WriteLine("\nWrong input, must press 1, 2 or 3");
                                                break;
                                        }
                                    }
                                } while (option > 3 || option == 0);
                                break;

                            case 2:
                                objGestor.SetCurrentCarShop(objGestor.CreateOneCarShop(objGestor.CurrentProvince, objGestor.RandomIntGenerator()));
                                Console.WriteLine("\nA new one has been created to take care of your vehicle");
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
            } while (option!=8);
        }
        

        private static void CarMethod(Gestor objGestor, MenuUI objMenu)
        {
            if (objGestor.CarRegistration(objGestor.CurrentCarShop, objMenu.RequestCarInfo()))
            {
                Console.WriteLine("\nYour car has been admitted");
            }
            else
            {
                Console.WriteLine("\nTheres been a problem admitting your car");
            }
        }

        private static void BikeMethod(Gestor objGestor, MenuUI objMenu)
        {
            if (objGestor.BikeRegistration(objGestor.CurrentCarShop, objMenu.RequestBikeInfo()))
            {
                Console.WriteLine("\nYour bike has been admitted");
            }
            else
            {
                Console.WriteLine("\nTheres been a problem admitting your bike");
            }
        }
    }
}
