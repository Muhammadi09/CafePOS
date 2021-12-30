using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafePOS
{
    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public Product(string name, string category, double price)
        {
            Name = name;
            Category = category;
            Price = price;
            SetDescription();
        }

        private void SetDescription()
        {
            this.Description = $"{Name.PadRight(20)} {String.Format("{0:0.00}",Price)}";
        }

    }
}
