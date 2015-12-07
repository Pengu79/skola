using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Radio
    {
        private byte volym;
        private bool turnRadioOn;
        private double frekvens;
        static int instanceCount;


        public static int InstanceCount
        {
            get { return instanceCount; }
        }
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

        public bool TurnRadioOn
        {
            get { return turnRadioOn; }
            set { turnRadioOn = value; }
        }


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
        static Radio()
        {
            instanceCount = 0;
        }
        public Radio()
        {
            instanceCount++;
            TurnRadioOn = false;
            Frekvens = 103.5;
            Volym = 50;
        }
        public Radio(double frekvens, byte volym) : this()
        {
            Frekvens = frekvens;
            Volym = volym;
        }
        public override string ToString()
        {
            return $"Frekvens:{frekvens} Volym:{volym} TurnRadioOn:{turnRadioOn} InstanceCount:{instanceCount}";
        }

    }
}
