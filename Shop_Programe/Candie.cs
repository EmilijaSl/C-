using System;
using System.Collections.Generic;
using System.Text;

namespace Shop_Programe
{
    public class Candie : Product
    {
        public double Sugar { get; set; }
        

        public Candie() { }
        public Candie(string name, decimal price, int barCode, double weight, double sugar)
        {
            Name = name;
            Price = price;
            BarCode = barCode;
            Weight = weight;
            Sugar = sugar;

        }
       
    }
}
