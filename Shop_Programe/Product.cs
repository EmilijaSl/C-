using System;
using System.Collections.Generic;
using System.Text;

namespace Shop_Programe
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int BarCode { get; set;}
        public double Weight { get; set; }

        public Product() { }

        public Product(string name, decimal price, int barCode, double weight)
        {
            Name = name;
            Price = price;
            BarCode = barCode;
            Weight = weight;
        }
    }
    
}

