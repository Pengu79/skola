using System;

namespace Exercise4
{
    internal class Radio
    {
        private double frekvens;
        private byte volym;

        static Radio()
        {
            InstanceCount = 0;
        }

        public Radio()
        {
            InstanceCount++;
            TurnRadioOn = false;
            Frekvens = 103.5;
            Volym = 50;
        }

        public Radio(double frekvens, byte volym) : this()
        {
            Frekvens = frekvens;
            Volym = volym;
        }


        public static int InstanceCount { get; private set; }

        public double Frekvens
        {
            get { return frekvens; }
            set
            {
                if (value > 88 && value < 109)
                {
                    frekvens = value;
                }
                else
                {
                    throw new Exception("Utanför frekvensområde");
                }
            }
        }

        public bool TurnRadioOn { get; set; }


        public byte Volym
        {
            get { return volym; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    volym = value;
                }
                else
                {
                    throw new Exception("Volym ska anges mellan 0-100");
                }
            }
        }

        public override string ToString()
        {
            return $"Frekvens:{frekvens} Volym:{volym} TurnRadioOn:{TurnRadioOn} InstanceCount:{InstanceCount}";
        }
    }
}