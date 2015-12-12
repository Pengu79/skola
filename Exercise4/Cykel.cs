using System;

namespace Exercise4
{
    internal class Cykel
    {
        private int _antalVaxlar;
        private int _currentGear;
        private string _marke;

        //static Cykel()
        //{
        //    _antalCyklar++;
        //}
        public Cykel()
        {
            AntalCyklar++;
            _marke = "No Name";
            _antalVaxlar = 1;
        }

        public Cykel(string marke, int antalVaxlar) : this()
        {
            Marke = marke;
            AntalVaxlar = antalVaxlar;
        }

        public int CurrentGear
        {
            get { return _currentGear; }
            set
            {
                if (value >= 0 && value <= _antalVaxlar)
                    _currentGear = value;
                else
                    throw new Exception("Ogiltig växel angiven");
            }
        }

        public int AntalVaxlar
        {
            get { return _antalVaxlar; }
            set
            {
                if (value >= 1 && value <= 21)
                {
                    _antalVaxlar = value;
                }
            }
        }

        public string Marke
        {
            get { return _marke; }
            set
            {
                if (value != null && value.Length >= 2)
                {
                    _marke = value;
                }
                else
                {
                    throw new Exception("Ogiltigt namn");
                }
            }
        }

        public static int AntalCyklar { get; private set; }

        public void GearUp()
        {
            CurrentGear++;
        }

        public void GearDown()
        {
            CurrentGear--;
        }

        public void RingBell()
        {
            Console.WriteLine("Pling Pling");
            Console.Beep();
        }
    }
}