using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Stock
    {
        private StockItem[] stockItems=new StockItem[0];
       
        public StockItem this[int index]
        {
            get { return stockItems[index]; }
        }
        public int getLength()
        {
            return stockItems.Length;
        }
        public void AddItem(StockItem item)
        {
            var tempStock= new StockItem[stockItems.Length+1];
            stockItems.CopyTo(tempStock, 0);
            stockItems = tempStock;
            stockItems[stockItems.Length - 1]=item;
        }
        public override string ToString()
        {
            StringBuilder outputString = new StringBuilder();
            for (int i = 0; i < stockItems.Length; i++)
            {
                outputString.AppendLine(stockItems[i].ToString());
                if (stockItems[i] is EcoStockItem)
                {
                    outputString.Append("Ekologisk Vara");
                }
               
            }
            return outputString.ToString();
        }
    }
}
