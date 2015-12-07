using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uppgift1();
            Console.WriteLine(Radio.InstanceCount);
            Radio radio1 = new Radio(100.3,55);
            Radio radio2 = new Radio(104.3, 43);
            Radio radio3 = new Radio(frekvens: 101.3, volym: 34);
            Radio radio4 = new Radio(frekvens: 99.2, volym: 20);
            Radio radio5 = new Radio() { Frekvens = 92.3, Volym = 22 };
            Console.WriteLine(radio1.ToString());

            
        
        }

        private static void Uppgift1()
        {
            Bil saab = new Bil();
            Bil volvo = new Bil();
            saab.Farg = "röd";
            saab.AntalVaxlar = 5;
            saab.Marke = "Saab";
            saab.Typ = "kombi";
            saab.Typ = "SUV";
            Console.WriteLine(saab.Typ);
        }
    }
}
