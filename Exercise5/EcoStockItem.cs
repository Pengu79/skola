using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class EcoStockItem : StockItem
    {
        private string markning;

        public string Markning
        {
            get { return markning; }
            set
            {
                if (value.Equals("krav", StringComparison.CurrentCultureIgnoreCase) || value.Equals("eg", StringComparison.CurrentCultureIgnoreCase))
                {
                    markning = value;
                }
                else
                    throw new Exception("Välj Krav eller EG");

            }
        }

        public override string ToString()
        {
            return base.ToString() + $"\n\rMarkning: { Markning}";
        }
    }
}
