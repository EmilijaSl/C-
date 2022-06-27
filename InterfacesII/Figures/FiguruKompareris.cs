using System;
using System.Collections.Generic;
using System.Text;
using InterfacesII.BBB;

namespace InterfacesII.Figures
{
    public class FiguruKompareris : IComparer<IPolygon>
    {
        public int Compare(IPolygon x, IPolygon y)
        {
            if (x.GetArea() > y.GetArea())
            { 
            return 1;
            }
            if (x.GetArea() < y.GetArea())
            {
                return -1;
            }
            return 0;
        }
    }
}
