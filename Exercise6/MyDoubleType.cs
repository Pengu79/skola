namespace Exercise6
{
    public class MyDoubleType
    {
        private double doubleValue;

        public double DoubleValue
        {
            get { return doubleValue; }
            set { doubleValue = value; }
        }

        public MyDoubleType(double d)
        {
            DoubleValue = d;
        }

        public override string ToString()
        {
            return doubleValue.ToString();
        }
    }
}