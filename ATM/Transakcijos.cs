using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    public class Transakcijos
    {
        public int PIN { get; set; }
        public decimal TransakcijosSuma { get; set; }
        public DateTime TransakcijosData { get; set; }
       
        public Transakcijos() { }
        public Transakcijos(int pin, decimal transakcijosSuma, DateTime transakcijosData)
        {
            PIN = pin;
            TransakcijosSuma = transakcijosSuma;
            TransakcijosData = transakcijosData;
        }
        

    }
}
