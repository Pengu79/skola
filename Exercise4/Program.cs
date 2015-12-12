using System;
using System.Threading;

namespace Exercise4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Cyckling();
        }

        private static void Cyckling()
        {
            var cyckel1 = new Cykel {AntalVaxlar = 5, Marke = "Rex"};
            var cyckel2 = new Cykel();
            var cykckel3 = new Cykel();
            var cyckling = true;
            int userChoice;
            bool validateChoice;
            while (cyckling)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine(@"Cykling simulator
1.Växla upp
2.Växla ner
3.Ringklocka
4.Sluta cykla" + $"\n\rNuvarande växel:{cyckel1.CurrentGear}");
                    Console.WriteLine(Cykel.AntalCyklar);
                    validateChoice = int.TryParse(Console.ReadLine(), out userChoice);
                    if (validateChoice && userChoice > 0 || validateChoice && userChoice <= 4)
                    {
                        switch (userChoice)
                        {
                            case 1:
                                cyckel1.GearUp();
                                break;
                            case 2:
                                cyckel1.GearDown();
                                break;
                            case 3:
                                cyckel1.RingBell();
                                Thread.Sleep(500);
                                break;
                            case 4:
                                cyckling = false;
                                break;
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Thread.Sleep(1000);
                }
                //Uppgift1();
                //RadioUppgiften();
            }
        }

        private static void RadioUppgiften()
        {
            Console.WriteLine(Radio.InstanceCount);
            var radio1 = new Radio(100.3, 55);
            var radio2 = new Radio(104.3, 43);
            var radio3 = new Radio(101.3, 34);
            var radio4 = new Radio(99.2, 20);
            var radio5 = new Radio {Frekvens = 92.3, Volym = 22};
            Console.WriteLine(radio1.ToString());
        }

        private static void Uppgift1()
        {
            var saab = new Bil();
            var volvo = new Bil();
            saab.Farg = "röd";
            saab.AntalVaxlar = 5;
            saab.Marke = "Saab";
            saab.Typ = "kombi";
            saab.Typ = "SUV";
            Console.WriteLine(saab.Typ);
        }
    }
}