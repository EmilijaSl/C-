using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Egzaminas_Dienynas.Repozitorijos
{
    public class Mokiniai_Repozitorija
    {
        public List<Mokinys> Mokiniai { get; set; }
        public Mokiniai_Repozitorija()
        {
            Mokiniai = new List<Mokinys>();
            CSV_Generatorius mok = new CSV_Generatorius();
            var data = mok.CSVGeneratorius(@"C:\Users\Emilija\Desktop\Trimestrai\Mokiniai.csv.txt");

            foreach (var item in data)
            {
                Mokiniai.Add(new Mokinys 
                { 
                Vardas = item[0],
                ID = Int32.Parse(item[1])
                });
            }
        }
        public List<Mokinys> Retrive()
        {
            return Mokiniai;
        }
        public List<Mokinys> RetriveID(int id)
        {
            return Mokiniai.Where(x => x.ID == id).ToList();  //metodas where grazina ne viena pazymi o visa sarasa
        }
        public void MokiniuSarasas()
        { 
        foreach(var item in Mokiniai)
                Console.WriteLine($"Mokinio ID ir vardas: {item.ID}{item.Vardas}");
        }
        public Mokinys RetriveID1(int id)
        {
            return Mokiniai.FirstOrDefault(x => x.ID == id);
        }

    }
}

























//public Mokinys RetriveVardas(string vardas)
//{
//    return Mokiniai.FirstOrDefault(x=> x.Vardas==vardas);
//}