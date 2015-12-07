using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Juice : EcoStockItem
    {
        private string typ;

        public string Typ
        {
            get { return typ; }
            set
            {
                
                if (value.Equals("orange",StringComparison.CurrentCultureIgnoreCase) || value.Equals("apple", StringComparison.CurrentCultureIgnoreCase))
                {
                    typ = value;
                }
                else
                    throw new Exception("Choose Orange or Apple!");
            }
        }
        public override string ToString()
        {
            return base.ToString() + $"\n\rTyp:{Typ}";
        }
    }
}
