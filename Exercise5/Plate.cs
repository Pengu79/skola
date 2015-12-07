using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Plate : StockItem
    {
        private string typ;

        public string Typ
        {
            get { return typ; }
            set
            {
                if (value.Equals("flat", StringComparison.CurrentCultureIgnoreCase) || value.Equals("deep", StringComparison.CurrentCultureIgnoreCase))
                {
                    typ = value;
                }
                else
                {
                    throw new Exception("Wrong value.Choose Flat or Deep");
                }
            }
        }
        public override string ToString()
        {
            return base.ToString() + $"\n\rTyp:{Typ}";
        }
    }
}
