using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Uzduotys
{
    public class BmwCar : Car1
    {
        //public string Model { get; set; }
        public bool IsXDrive { get; set; }
        //public int Fuel { get; set; }

        public BmwCar(bool isXDrive, string model, int fuel)
        {
            IsXDrive = isXDrive;
            Model = model;
            Fuel = fuel;
        }
    }
}
