using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise4;

namespace ovningArv
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pointen();
            //Bilar();
            Cat kurre = new Cat();
            Console.WriteLine(kurre.GetSound());
            Bengal benji = new Bengal();
            Cat kalle = new Cat();
            //kalle = benji as Cat;
            kalle.Weight = 50;
            Bengal bosse = new Bengal();
            bosse = kalle as Bengal;
            Console.WriteLine(bosse.Weight);

        }

        private static void Bilar()
        {
            //C ceasar = new C();
            SUV X5 = new SUV();
            //X5.Drive();
            Bil bmw = new SUV();
            //SUV fiat = new Bil();
            Bil x4 = new Bil();
            Bil apa = new SUV();
            apa = X5;
            //x4.Drive();
            //X5 = (SUV)x4;

            apa.Drive();
        }

        private static void Pointen()
        {
            Point3D pointen = new Point3D();
            pointen.X = 4;
            pointen.Y = 150;
            pointen.Z = 100;
            Point3D testen = new Point3D(50, 200, 25);
            Console.WriteLine(testen);
        }
    }
}
