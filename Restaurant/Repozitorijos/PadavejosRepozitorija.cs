using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Restaurant.Entities;
using Restaurant.Interfaces;
using Restaurant.Meniu;

namespace Restaurant.Repozitorijos
{
    public class PadavejosRepozitorija : IRepozitorija <Padaveja>
    {
        public List<Padaveja> Padavejos { get; set; }
        public PadavejosRepozitorija()
        {
            Padavejos = new List<Padaveja>();
            CSV_Reader csv = new CSV_Reader();
            var data = csv.CSV_Generatorius(@"C:\Users\Emilija\Desktop\Trimestrai\Padaveja.csv.txt");
            foreach (var item in data)
            {
                Padavejos.Add(new Padaveja
                {
                    PadavejosID = Int32.Parse(item[0]),
                    PadavejosVardas = item[1]
                });
            }
        }
        public void RodykVisus()
        {
            foreach (var item in Padavejos)
            {
                Console.WriteLine($"Padavejo ID: {item.PadavejosID}, padavejo vardas: {item.PadavejosVardas}");
            }
        }
        public Padaveja RetriveByID(int id)
        {
            return Padavejos.SingleOrDefault(x=>x.PadavejosID==id);
        }
    }
}

    
    
        
            