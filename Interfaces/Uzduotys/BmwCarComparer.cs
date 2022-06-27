using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Uzduotys
{
    public class BmwCarComparer : IComparer<BmwCar>
    {
        public int Compare(BmwCar x, BmwCar y)
        {
            return string.Compare(x.Model, y.Model);
        }
    }
}
