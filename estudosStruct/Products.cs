using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosStruct
{
    public class Products
    {
        public string ProductName;
        public double Price;
        public int Quantity;

        public Products(string productname, double price, int quantity)
        {
            ProductName = productname;
            Price = price;
            Quantity = quantity;    
        }

    }
}
