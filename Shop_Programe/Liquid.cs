using System;
using System.Collections.Generic;
using System.Text;

namespace Shop_Programe
{
    public class Liquid : Product 
    {
        
        public Liquid() { }
        public Liquid(string name, decimal price, int barCode, double weight)
        {
            Name = name;
            Price = price;
            BarCode = barCode;
            Weight = weight;
            

        }
        
        
    }
}
