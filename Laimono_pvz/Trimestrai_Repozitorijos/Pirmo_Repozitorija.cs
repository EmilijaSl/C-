using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dienynas.Esme;
using Dienynas.Trimestrai;

namespace Dienynas.Trimestrai_Repozitorijos
{
    public class Pirmo_Repozitorija
    {
        public List<Pirmas_Trimestras> PirmoTrimestroDuomenys { get; set; }
        public Pirmo_Repozitorija()
        {
            PirmoTrimestroDuomenys = new List<Pirmas_Trimestras>();
            CSV_Getter pirmas = new CSV_Getter();
            var data = pirmas.CSVGetter(@"C:\Users\Emilija\Desktop\Trimestrai\pirmasTrimestras.csv.txt");

            foreach (var item in data)
            {
                var grades = new List<int>();
                foreach (var number in item[2].Split(','))
                {
                    grades.Add(int.Parse(number));
                }

               PirmoTrimestroDuomenys.Add(new Pirmas_Trimestras
                {
                    ID = Convert.ToInt32(item[0]),
                    FullName = item[1],
                    Grades = grades

                });
            }
        }
        public Pirmas_Trimestras Retrive(int id)
        {
            return PirmoTrimestroDuomenys.FirstOrDefault(x => x.ID == id);
        }
        public Pirmas_Trimestras RetriveGrades(List<int> grades)
        {
            return PirmoTrimestroDuomenys.FirstOrDefault(x=> x.Grades == grades);
        }
        public List<Pirmas_Trimestras> Retrive()
        {
            return PirmoTrimestroDuomenys;
        }
        public void MokiniuSarasas()
        {
            foreach (var item in PirmoTrimestroDuomenys)
            {
                Console.WriteLine($"Mokinio ID: {item.ID}, Mokinio Vardas: {item.FullName}");
            }
        }
        
    }
}
