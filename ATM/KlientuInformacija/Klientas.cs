using System;
using System.Collections.Generic;
using System.Text;

namespace ATM.KlientuInformacija
{
    public class Klientas
    {
        public int PIN { get; set; }
        public decimal PinigaiSaskaitoje { get; set; }
        public Klientas() 
        { }
        public Klientas(int pin, decimal pinigaiSaskaitoje)
        {
            PIN = pin;
            PinigaiSaskaitoje = pinigaiSaskaitoje;
        }
    }
}
