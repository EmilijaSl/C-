using System;
using System.Collections.Generic;
using System.Text;
using InterfacesII.BBB;

namespace InterfacesII.Figures
{
    class Kvadratas : IPolygon
    {
        public double KrastineA { get; set; }
        public double KrastineB { get; set; }
        public Kvadratas() { }
        public Kvadratas(double krastineA, double krastineB)
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
