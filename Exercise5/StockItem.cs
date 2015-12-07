using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class StockItem
    {
        private int id;
        private string name;
        private int stockCount;

        public int StockCount
        {
            get { return stockCount; }
            set {
                if (value >= 0 && value <= 200)
                {
                    stockCount = value;
                }
                else
                    throw new Exception("Ange ett värde mellan 0 och 200");
                 }
        }

        public string Name
        {
            get { return name; }
            set {
                if (value.Length>=2&&value.Length<=20)
                {
                    name = value;
                }else
                    throw new Exception("Ange ett namn på mellan 2 och 20 bokstäver");
                
                 }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public override string ToString()
        {
            return $"Id:{Id}\n\rName:{Name}\n\rStockcount:{StockCount}";
        }
    }
}
