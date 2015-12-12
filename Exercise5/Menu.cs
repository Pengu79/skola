using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    static class Menu
    {
        static String[] mainMenu = new String[] { "1.Skapa vara", "2.Inventera vara", "3.Lista varor", "4.Avsluta" };
        static String[] createItem = new String[] { "1.Skapa Juice", "2.Skapa Tallrik", "3.Tillbaka" };
        static String[] reStockInventory = new String[] { "1.Inventera alla varor", "2.Inventera Tallrikar", "3.Inventera Juicer", "4.Tillbaka" };
        static String[] listInventory = new string[] { "1.Lista alla varor", "2.Lista Tallrikar", "3.Lista juicer", "4.Tillbaka" };
        public static string DrawMenu(string[] menuItems)
        {
            Console.Clear();
            StringBuilder menuText = new StringBuilder();

            for (int i = 0; i < menuItems.Length; i++)
            {
                menuText.AppendLine(menuItems[i]);
            }
            return menuText.ToString();
        }
        public static string DrawMainMenu()
        {
            bool isLegit = true;
            int userChoice;
            Console.WriteLine(DrawMenu(mainMenu));
            isLegit = int.TryParse(Console.ReadLine(), out userChoice);
            if (isLegit)
            {
                switch (userChoice)
                {
                    case 1:
                        return "createItem";
                    case 2:
                        return "restockItem";
                    case 3:
                        return "listItems";
                    case 4:
                        return "exitProgram";

                    default:
                        return "root";

                }
            }
            else
                throw new Exception("Ange värde som motsvarar menyn");


        }
        public static string DrawInventoryMenu()
        {
            bool isLegit = true;
            int userChoice;
            Console.WriteLine(DrawMenu(listInventory));
            isLegit = int.TryParse(Console.ReadLine(), out userChoice);
            if (isLegit == true)
            {
                switch (userChoice)
                {
                    case 1:
                        return "listAll";
                    case 2:
                        return "listPlate";
                    case 3:
                        return "listJuice";
                    case 4:
                        return "root";
                    default:
                        return "root";
                }
            }
            else
                throw new Exception("Ange värde som motsvarar menyn");
        }
        public static string DrawCreateItemMenu()
        {
            bool isLegit = true;
            int userChoice;
            Console.WriteLine(DrawMenu(createItem));
            isLegit = int.TryParse(Console.ReadLine(), out userChoice);
            if (isLegit == true)
            {
                switch (userChoice)
                {
                    case 1:
                        return "createJuice";
                    case 2:
                        return "createPlate";
                    case 3:
                        return "root";
                    default:
                        return "root";
                }
            }
            else
                throw new Exception("Ange värde som motsvarar menyn");
        }
        public static string DrawReStockMenu()
        {
            bool isLegit = true;
            int userChoice;
            Console.WriteLine(DrawMenu(reStockInventory));
            isLegit = int.TryParse(Console.ReadLine(), out userChoice);
            if (isLegit == true)
            {
                switch (userChoice)
                {
                    case 1:
                        return "restockAll";
                    case 2:
                        return "restockPlate";
                    case 3:
                        return "restockJuice";
                    case 4:
                        return "root";
                    default:
                        return "root";
                }
            }
            else
                throw new Exception("Ange värde som motsvarar menyn");
        }
    }
}
