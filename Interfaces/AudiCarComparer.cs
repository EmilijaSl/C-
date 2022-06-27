using System;
using System.Collections.Generic;
using System.Text;
using Interfaces.Uzduotys;

namespace Interfaces
{
    public class AudiCarComparer : IComparer<AudiCar>
    {
        public int Compare(AudiCar x, AudiCar y)
        {
            return string.Compare(x.Model, y.Model);
        }
    }
}

}