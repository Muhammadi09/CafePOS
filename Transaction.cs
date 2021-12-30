using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafePOS
{
    public class Transaction
    {
        private readonly List<Product> items;
        private DateTime dateTime;
        public Transaction()
        {
            items = new List<Product>();
            dateTime = DateTime.Now;
        }

        public void AddItems(Product item)
        {
            items.Add(item);
        }
        public List<Product> GetItems()
        {
            return items;
        }
        public DateTime GetDate()
        {
            return dateTime;
        }
    }
}
