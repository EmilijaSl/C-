using System;
using System.Collections.Generic;
using System.Text;
using Shop_Programe.NewFolder;

namespace Shop_Programe
{
    public class ShopingCart
    {
      
        public List<Product> Products { get; set; } //susikuriame produktu sarasa
   


        public ShopingCart()
        {
            Products = new List<Product>();
        }


        public bool AddCandy(int barCode, double quantity, Candie_Repository candie_Repository)
        {
            
            var candy = candie_Repository.Retrive(barCode); //pasiimame saldaini pagal bar coda
            if (quantity <= candy.Weight) //tikriname, ar pakankamas kiekis pagal svori

            {
                var candyToAdd = new Candie(); ///susikuriam nauja saldaini pridejimui
                candyToAdd.Name = candy.Name;
                candyToAdd.Price = candy.Price;
                candyToAdd.BarCode = candy.BarCode;
                candyToAdd.Weight = quantity;
                Products.Add(candyToAdd); //pridedame pasirinkta preke pagal barkoda i 
                candy.Weight -= quantity;
                return true;

            }
            else 
            {
                Console.WriteLine("Insufficient balance of goods");
                Console.ReadLine();
                return false;
            }
          
        }
        public bool AddMeat(int barCode, double quantity, Meat_Repository meat_Repository)
        {
            var meat = meat_Repository.Retrive(barCode);
            if (quantity <= meat.Weight)
            {
                var meatToAdd = new Meat();
                meatToAdd.Name = meat.Name;
                meatToAdd.Price = meat.Price;
                meatToAdd.BarCode = meat.BarCode;
                meatToAdd.Weight = quantity;
                Products.Add(meatToAdd);
                meat.Weight -= quantity;
                return true;
            }
            else
            {
                Console.WriteLine("Insufficient balance of goods");
                Console.ReadLine();
                return false;
            }
        }
        public bool AddLiquid(int barCode, double quantity, Liquid_Repository liquid_Repository)
        {
            var liquid = liquid_Repository.Retrive(barCode);
            if (quantity <= liquid.Weight)
            {
                var liquidToAdd = new Liquid();
                liquidToAdd.Name = liquid.Name;
                liquidToAdd.Price = liquid.Price;
                liquidToAdd.BarCode = liquid.BarCode;
                liquidToAdd.Weight = quantity;
                Products.Add(liquidToAdd);
                liquid.Weight -= quantity;
                return true;
            }
            else
            {
                Console.WriteLine("Insufficient balance of goods");
                Console.ReadLine();
                return false;
            }

        }
        public bool AddVegetables(int barCode, double quantity, Vegetable_Repository vegetable_Repository)
        {
            var vegetable = vegetable_Repository.Retrive(barCode);
            if (quantity <= vegetable.Weight)
            {
                var vegetableToAdd = new Vegetable();
                vegetableToAdd.Name = vegetable.Name;
                vegetableToAdd.Price = vegetable.Price;
                vegetableToAdd.BarCode = vegetable.BarCode;
                vegetableToAdd.Weight = quantity;
                Products.Add(vegetableToAdd);
                vegetable.Weight -= quantity;
                return true;
            }
            else
            {
                Console.WriteLine("Insufficient balance of goods");
                Console.ReadLine();
                return false;
            }
        }
        public void ClearCart()
        {
            Products.Clear();
        }
    }
}
