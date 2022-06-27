using System;
using System.Collections.Generic;
using System.Text;

namespace Egzaminas_Dienynas
{
    public class Mokinys
    {
        public string Vardas { get; set; }
        public int ID { get; set; }
        public Mokinys() { }
        public Mokinys(string vardas, int id)
        {
            Vardas = vardas;
            ID = id;
        }
    }
}
