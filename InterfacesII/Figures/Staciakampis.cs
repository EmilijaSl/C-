using System;
using System.Collections.Generic;
using System.Text;
using InterfacesII.BBB;

namespace InterfacesII.Figures
{
    public class Staciakampis : IPolygon
    {

        public double KrastineA { get; set; }
        public double KrastineB { get; set; }
        public Staciakampis() { }
        public Staciakampis(double krastineA, double krastineB)
        {
            KrastineA = krastineA;
            KrastineB = krastineB;
        }
        public double GetArea()
        {
            return KrastineA * KrastineB;
        }

    }
}
