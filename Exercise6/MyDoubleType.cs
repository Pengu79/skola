namespace Exercise6
{
    public class MyDoubleType
    {
        private double _doubleValue;

        public double DoubleValue
        {
            get { return _doubleValue; }
            set { _doubleValue = value; }
        }

        public MyDoubleType()
        {
            DoubleValue = 55.323;
        }
        public MyDoubleType(double d)
        {
            DoubleValue = d;
        }

        public override string ToString()
        {
            return _doubleValue.ToString();
        }
        public static MyDoubleType operator +(MyDoubleType myDoubleType,double duo)
        {
            myDoubleType.DoubleValue += duo;
            return myDoubleType;
        }
        public static MyDoubleType operator +(MyDoubleType myDoubleType, MyDoubleType duo)
        {
            myDoubleType.DoubleValue += duo.DoubleValue;
            return myDoubleType;
        }
        public static MyDoubleType operator -(MyDoubleType myDoubleType, double duo)
        {
            myDoubleType.DoubleValue -= duo;
            return myDoubleType;
        }
        public static MyDoubleType operator /(MyDoubleType myDoubleType, double duo)
        {
            myDoubleType.DoubleValue /= duo;
            return myDoubleType;
        }
        public static MyDoubleType operator *(MyDoubleType myDoubleType, double duo)
        {
            myDoubleType.DoubleValue *= duo;
            return myDoubleType;
        }
        public static bool operator ==(MyDoubleType myDoubleType, double duo)
        {
            return myDoubleType.DoubleValue == duo;
            
        }

        public static bool operator !=(MyDoubleType myDoubleType, double duo)
        {
            return !(myDoubleType.DoubleValue == duo);
        }
        public static bool operator <(MyDoubleType myDoubleType, double duo)
        {
            return myDoubleType.DoubleValue<duo;
        }
        public static bool operator <(MyDoubleType myDoubleType, MyDoubleType duo)
        {
            return myDoubleType.DoubleValue < duo.DoubleValue;
        }

        public static bool operator >(MyDoubleType myDoubleType, MyDoubleType duo)
        {
            return myDoubleType.DoubleValue > duo.DoubleValue;
        }

        public static bool operator >(MyDoubleType myDoubleType, double duo)
        {
            return myDoubleType.DoubleValue > duo;
        }
    }
}