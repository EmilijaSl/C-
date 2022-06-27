using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Uzduotys
{
    public class Uzduotys
    {
    }
    #region 1 uzduotis
    public class Car : ICar
    { 
        public string Model { get; set; }
        public int Fuel { get; set; }
        public bool Drive()
        {
            if (Fuel != 0)
            {
                Console.WriteLine($"You got a fast car {Model} I got a plan to get us outta here");
                return true;
            }
            else
            {
                Console.WriteLine("Go get some fuel");
                return false;
            }
            
        }
        public void Refuel(int fuelToAdd)
        {
            if (fuelToAdd > 0)
            {
                Console.WriteLine("Pyleisi 95, pamaciau galvojau trenkta");
            }
            else
            {
                Console.WriteLine("No fuel was added");
            }
            
        }
    }
  
    #endregion
    #region 2 uzduotis
    public abstract class Car1 : ICar
    {
        public string Model { get; set; }
        public int Fuel { get; set; }
        public bool Drive()
        {
            if (Fuel != 0)
            {
                Console.WriteLine($"You got a fast car {Model} I got a plan to get us outta here");
                return true;
            }
            else
            {
                Console.WriteLine("Go get some fuel");
                return false;
            }

        }
        public void Refuel(int fuelToAdd)
        {
            if (fuelToAdd > 0 && fuelToAdd< 99)
            {
                Console.WriteLine($"Pyleisi {fuelToAdd} litru 95, pamaciau galvojau trenkta.");
            }
            if (fuelToAdd>=100)
            {
                Console.WriteLine($"Max bako talpa 100 litru, tad {fuelToAdd} nebepareis");
            }

        }
    }
  
   
    interface IVehicle1
    {
        bool Drive();
        void Refuel(int fuelToAdd);
    }

    #endregion



}

