using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafePOS
{
    public static class Payment
    {
        private static double price;

        public static void UpdatePrice(double p)
        {
            price = p;
        }

        public static double GetPrice()
        {
            return price;
        }
    }
}
