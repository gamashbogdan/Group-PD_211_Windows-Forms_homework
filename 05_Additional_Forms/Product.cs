using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_na_25._11
{
    public class Product
    {
        public Product()
        {
        }
        public Product(string name, double price, int quantity, string countri, int discount)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Countri = countri;
            Discount = discount;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Countri { get; set; }
        public int Discount { get; set; }
        public override string ToString()
        {
            return $"Name - {Name},  Price - {Price},  Discount - {Discount}";
        }
    }
}
