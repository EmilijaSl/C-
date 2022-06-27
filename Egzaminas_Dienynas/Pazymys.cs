using System;
using System.Collections.Generic;
using System.Text;

namespace Egzaminas_Dienynas
{
    public class Pazymys
    {
        public int Balas { get; set; }
        public int ID { get; set; }
        public int Trimestras { get; set; }

        public Pazymys() { }
        public Pazymys(int balas, int id, int trimestras)
        {
            Balas = balas;
            ID = id;
            Trimestras = trimestras;
        }

    }
}
