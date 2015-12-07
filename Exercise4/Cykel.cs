using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Cykel
    {
        private string marke;
        private int antalVaxlar;
        private static int antalCyklar = 0;

        public int AntalVaxlar
        {
            get { return antalVaxlar; }
            set
            {
                if (value >= 1 && value <= 21)
                {
                    antalVaxlar = value;
                }
            }
        }

        public string Marke
        {
            get { return marke; }
            set
            {
                if (value != null && value.Length >= 2)
                {
                    marke = value;
                }
                else
                {
                    throw new Exception("Ogiltigt namn");
                }
            }
        }
        static Cykel()
        {
            antalCyklar++;
        }
        public Cykel()
        {
            marke = "No Name";
            antalVaxlar = 1;
        }
        public Cykel(string marke, int antalVaxlar) : this()
        {
            Marke = marke;
            AntalVaxlar = antalVaxlar;
        }
    }
}
