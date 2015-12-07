using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    public class Bil
    {
        private string marke, farg, typ;
        private int antalVaxlar;

        public int AntalVaxlar
        {
            get { return antalVaxlar; }
            set
            {
                if (value > 0 && value < 7)
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
                if (value != null)
                {
                    marke = value;
                }
            }
        }
        public string Farg
        {
            get { return farg; }
            set
            {
                if (value != null)
                {
                    farg = value;
                }
                else
                {
                    throw new Exception("Ingen färg är satt");
                }
            }
        }
        public string Typ
        {
            get { return typ; }
            set
            {
                if (value != null && value == "kupe" || value == "kombi")
                {
                    typ = value;
                }
            }
        }
        public virtual void Drive()
        {
            Console.WriteLine("Brum Brum");
        }
    }
}
