using System;
using System.Collections.Generic;
using System.Text;

namespace Shop_Programe
{
    
    public class Meat : Product
    {
        public double Carbs { get; set; }
        


        public Meat() { }
        public Meat(string name, decimal price, int barCode, double weight, double carbs)
        {
            Name = name;
            Price = price;
            BarCode = barCode;
            Weight = weight;
            Carbs = carbs;

        }
       

        
    }
}
