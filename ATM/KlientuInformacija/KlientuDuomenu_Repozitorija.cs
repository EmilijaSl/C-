using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM.KlientuInformacija
{
    public class KlientuDuomenu_Repozitorija
    {
        public List<Klientas> Klientai { get; set; }
        public KlientuDuomenu_Repozitorija()
        {
            Klientai = new List<Klientas>();
            CSVGeneratorius kl = new CSVGeneratorius();
            var data = kl.CSV_Generatorius(@"C:\Users\Emilija\Desktop\Trimestrai\ATMinfo.csv.txt");

            foreach (var item in data)
            {
                Klientai.Add(new Klientas
                { 
                PIN = Int32.Parse(item[0]),
                PinigaiSaskaitoje = decimal.Parse(item[1])
                });
            }
        }
        public List<Klientas> Retrive()
        {
            return Klientai;
        }
        public List<Klientas> RetrivePIN(int pin)
        {
            return Klientai.Where(x => x.PIN == pin).ToList();
        }
        public Klientas RetriveByPIN(int pin)
        { 
        return Klientai.FirstOrDefault(x => x.PIN == pin);
        }
        public void IdetiPinigu(decimal suma, int pin)
        {
            Klientai.Add(new Klientas(pin, suma));
        }
    }
}
