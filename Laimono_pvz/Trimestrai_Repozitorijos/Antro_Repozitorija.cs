using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dienynas.Esme;
using Dienynas.Trimestrai;

namespace Dienynas.Trimestrai_Repozitorijos
{
    public class Antro_Repozitorija
    {
        public List<Antras_Trimestras> AntroTrimestroDuomenys { get; set; }
        public Antro_Repozitorija()
        {
            AntroTrimestroDuomenys = new List<Antras_Trimestras>();
            CSV_Getter antras = new CSV_Getter();
            var data = antras.CSVGetter(@"C:\Users\Emilija\Desktop\Trimestrai\antrasTrimestras.csv.txt");

            foreach (var item in data)
            {
                var grades = new List<int>();

                foreach (var number in item[2].Split(','))
                {
                    grades.Add(int.Parse(number));
                }
                AntroTrimestroDuomenys.Add(new Antras_Trimestras
                {
                    ID = Convert.ToInt32(item[0]),
                    FullName = item[1],
                    Grades = grades

                });
            }
        }
        public Antras_Trimestras Retrive(int id)
        {
            return AntroTrimestroDuomenys.FirstOrDefault(x => x.ID == id);
        }
        public Antras_Trimestras RetriveGrades(List<int> grades)
        {
            return AntroTrimestroDuomenys.FirstOrDefault(x => x.Grades == grades);
        }
        public List<Antras_Trimestras> Retrive()
        {
            return AntroTrimestroDuomenys;
        }
        public void MokiniuSarasas()
        {
            foreach (var item in AntroTrimestroDuomenys)
            {
                Console.WriteLine($"Mokinio ID: {item.ID}, Mokinio Vardas: {item.FullName}");
            }
        }
    }
}
