using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Uzduotys
{
    public class AudiCar : Car1
    {
        public bool IsQuatro { get; set; }
        public AudiCar(bool isQuatro, string model, int fuel)
        {
            IsQuatro = isQuatro;
            Model = model;
            Fuel = fuel;
        }
    }
}
