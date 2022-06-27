using System;
using System.Collections.Generic;
using System.Text;
using InterfacesII.BBB;

namespace InterfacesII.Figures
{
    public class Trikampis : IPolygon
    {
        public double KrastineA { get; set; }
        public double KrastineB { get; set; }
        public Trikampis() { }
        public Trikampis(double krastineA, double krastineB)
        {
            KrastineA = krastineA;
            KrastineB = krastineB;
        }
        public double GetArea()
        {
            return (KrastineA * KrastineB) / 2;
        }
    }
}
