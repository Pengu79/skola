using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Uppgift1();
            //Uppgift2();
            //Uppgift4();
            //Uppgift5();
        }

        private static void Uppgift5()
        {
            Dog puppy = new Dog();
            puppy.SetRace("Dalmation");
            puppy.SetName("Bumbi");
            puppy.SetLegs(4);
            puppy.SetColor("white", "black");
            Console.WriteLine(puppy.DogInformation());
        }

        private static void Uppgift4()
        {
            Point one = new Point();
            one.Y=2;
            one.Y=4;
            Circle circle101 = new Circle();
            circle101.SetCenter(one);
            circle101.SetDiameter("104,5");
        }

        private static void Uppgift2()
        {
            Circle circle1 = new Circle();
            Circle circle2 = new Circle();
            Circle circle3 = new Circle();
            circle1.SetDiameter("2,335");
            circle2.SetDiameter("4,2424");
            circle3.SetDiameter("44,3344");
            Console.WriteLine(circle1.GetCircumference());
            Console.WriteLine(circle2.GetCircumference());
            Console.WriteLine(circle3.GetCircumference());
        }

        private static void Uppgift1()
        {
            Person lars = new Person();
            Person nisse = new Person();
            Person kajsa = new Person();
            lars.SetName("Lars");
            nisse.SetName("Nisse");
            kajsa.SetName("Kajsa");
            Console.WriteLine(lars.GetName());
            Console.WriteLine(nisse.GetName());
            Console.WriteLine(kajsa.GetName());
        }
    }
}
