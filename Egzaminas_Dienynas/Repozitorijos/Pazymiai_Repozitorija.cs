using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Egzaminas_Dienynas.Repozitorijos
{
    public class Pazymiai_Repozitorija
    {
        public List<Pazymys> Pazymiai { get; set; }
        public Pazymiai_Repozitorija()
        {
            Pazymiai = new List<Pazymys>();
            CSV_Generatorius paz = new CSV_Generatorius();
            var data = paz.CSVGeneratorius(@"C:\Users\Emilija\Desktop\Trimestrai\Pazymiai.csv.txt");

            foreach (var item in data)
            {
                Pazymiai.Add(new Pazymys 
                { 
                Balas = Int32.Parse(item[0]),
                ID = Int32.Parse(item[1]),
                Trimestras = Int32.Parse(item[2])
                });
            }
        }
        public List<Pazymys> Retrive()
        {
            return Pazymiai;
        }
        public List<Pazymys> RetriveID(int id)
        {
            return Pazymiai.Where(x=>x.ID ==id).ToList();  //metodas where grazina ne viena pazymi o visa sarasa
        }
        public void PridetiPazymi(int balas, int id, int trimestras)
        {
            Pazymiai.Add(new Pazymys(balas, id, trimestras));
        }
        public List<Pazymys> RetriveTrimestras(int trimestras, int id)
        {
            return Pazymiai.Where(x => x.Trimestras == trimestras && x.ID == id).ToList();
        }
        public Pazymys RetriveID1(int id)
        {
            return Pazymiai.FirstOrDefault(x => x.ID == id);
        }

        public Pazymys RetriveTrimestras1(int trimestras, int id)
        {
            return Pazymiai.FirstOrDefault((x => x.Trimestras == trimestras && x.ID == id));
        }

    }
}
