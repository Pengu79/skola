using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static Stock lagret = new Stock();
        static void Main(string[] args)
        {

            bool isRunning = true;
            string currentState = "root";
            do
            {
                try
                {
                    switch (currentState)
                    {
                        case "root":
                            currentState = Menu.DrawMainMenu();
                            break;
                        case "createItem":
                            currentState = Menu.DrawCreateItemMenu();
                            break;
                        case "createJuice":
                            CreateJuice();
                            currentState = "createItem";
                            break;
                        case "createPlate":
                            CreatePlate();
                            currentState = "createItem";
                            break;
                        case "restockItem":
                            currentState = Menu.DrawReStockMenu();
                            break;
                        case "restockAll":
                            reStock<StockItem>();
                            currentState = "restockItem";
                            break;
                        case "restockPlate":
                            reStock<Plate>();
                            currentState = "restockItem";
                            break;
                        case "restockJuice":
                            reStock<Juice>();
                            currentState = "restockItem";
                            break;
                        case "listItems":
                            currentState = Menu.DrawInventoryMenu();
                            break;
                        case "listAll":
                            listStock<StockItem>();
                            currentState = "listItems";
                            break;
                        case "listPlate":
                            listStock<Plate>();
                            currentState = "listItems";
                            break;
                        case "listJuice":
                            listStock<Juice>();
                            currentState = "listItems";
                            break;

                        case "exitProgram":
                            isRunning = false;
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }

            } while (isRunning == true);
            
        }
        public static void CreateJuice()
        {
            Console.Clear();
            bool valid = false;
            Juice tempJuice = new Juice();
            while (valid == false)
            {
                try
                {

                    Console.WriteLine("Ange typ av juice(Apple or Orange):");
                    tempJuice.Typ = Console.ReadLine();
                    valid = true;
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);
                }
            }
            valid = false;
            Console.Clear();
            while (valid == false)
            {
                Console.WriteLine("Ange artikelnummer:");
                int tempId;
                valid = int.TryParse(Console.ReadLine(), out tempId);
                if (valid == true)
                {
                    tempJuice.Id = tempId;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Artikelnummer måste vara ett heltal");
                }
            }
            valid = false;
            Console.Clear();
            while (valid == false)
            {
                try
                {
                    Console.WriteLine("Ange namn på produkten:");
                    tempJuice.Name = Console.ReadLine();
                    valid = true;
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);
                }
            }
            valid = false;
            Console.Clear();
            while (valid == false)
            {
                Console.WriteLine($"Ange hur många {tempJuice.Name} du fått in på lager:");
                int tempStockCount;
                valid = int.TryParse(Console.ReadLine(), out tempStockCount);
                if (valid == true)
                {
                    tempJuice.StockCount = tempStockCount;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Antal måste vara ett heltal");
                }
            }
            valid = false;
            Console.Clear();
            while (valid == false)
            {
                try
                {
                    Console.WriteLine($"Ange om {tempJuice.Name} är Krav eller EG:");
                    tempJuice.Markning = Console.ReadLine();
                    valid = true;
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);
                }
            }
            Console.Clear();
            var checkIfSave = false;
            while (checkIfSave == false)
            {
                Console.WriteLine("Du har angett följande:");
                Console.WriteLine(tempJuice.ToString());
                Console.WriteLine("Vill du spara detta?J/N");
                char save;
                char.TryParse(Console.ReadLine(), out save);
                if (save == 'J' || save == 'j')
                {
                    lagret.AddItem(tempJuice);
                    checkIfSave = true;
                    Console.WriteLine("Varan är sparad");
                    System.Threading.Thread.Sleep(1000);
                }
                else if (save == 'n' || save == 'N')
                {
                    Console.WriteLine("Varan sparades inte");
                    System.Threading.Thread.Sleep(1000);
                    checkIfSave = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Du måste ange J eller N");
                }
            }
        }
        public static void CreatePlate()
        {
            Console.Clear();
            bool valid = false;
            Plate tempPlate = new Plate();
            while (valid == false)
            {
                try
                {

                    Console.WriteLine("Ange typ av tallrik(Flat or Deep):");
                    tempPlate.Typ = Console.ReadLine();
                    valid = true;
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);
                }
            }
            valid = false;
            Console.Clear();
            while (valid == false)
            {
                Console.WriteLine("Ange artikelnummer:");
                int tempId;
                valid = int.TryParse(Console.ReadLine(), out tempId);
                if (valid == true)
                {
                    tempPlate.Id = tempId;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Artikelnummer måste vara ett heltal");
                }
            }
            valid = false;
            Console.Clear();
            while (valid == false)
            {
                try
                {
                    Console.WriteLine("Ange namn på produkten:");
                    tempPlate.Name = Console.ReadLine();
                    valid = true;
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);
                }
            }
            valid = false;
            Console.Clear();
            while (valid == false)
            {
                Console.WriteLine($"Ange hur många {tempPlate.Name} du fått in på lager:");
                int tempStockCount;
                valid = int.TryParse(Console.ReadLine(), out tempStockCount);
                if (valid == true)
                {
                    tempPlate.StockCount = tempStockCount;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Antal måste vara ett heltal");
                }
            }

            Console.Clear();
            var checkIfSave = false;
            while (checkIfSave == false)
            {
                Console.WriteLine("Du har angett följande:");
                Console.WriteLine(tempPlate.ToString());
                Console.WriteLine("Vill du spara detta?J/N");
                char save;
                char.TryParse(Console.ReadLine(), out save);
                if (save == 'J' || save == 'j')
                {
                    lagret.AddItem(tempPlate);
                    checkIfSave = true;
                    Console.WriteLine("Varan är sparad");
                    System.Threading.Thread.Sleep(1000);
                }
                else if (save == 'n' || save == 'N')
                {
                    Console.WriteLine("Varan sparades inte");
                    System.Threading.Thread.Sleep(1000);
                    checkIfSave = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Du måste ange J eller N");

                }
            }
        }
        public static void reStock<T>()
        {
            int tempStock;
            bool validInput = false;

            for (int i = 0; i < lagret.getLength(); i++)
            {
                try
                {
                    if (lagret[i] is T)
                    {
                        while (validInput == false)
                        {
                            Console.WriteLine($"Hur många {lagret[i].Name} av typen {lagret[i].GetType().Name} finns det i lagret?(Gamla antalet var:{lagret[i].StockCount}):");
                            validInput = int.TryParse(Console.ReadLine(), out tempStock);
                            if (validInput == true)
                            {
                                lagret[i].StockCount = tempStock;
                            }
                            else
                            {
                                Console.WriteLine("Du måste ange ett heltal!");
                            }
                        }
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public static void listStock<T>()
        {
            for (int i = 0; i < lagret.getLength(); i++)
            {
                if (lagret[i] is T)
                {
                    Console.WriteLine(lagret[i].ToString() + "\n\r");

                }
            }
            Console.WriteLine("Tryck en tangent för att gå vidare");
            Console.ReadLine();
        }
    }
}

