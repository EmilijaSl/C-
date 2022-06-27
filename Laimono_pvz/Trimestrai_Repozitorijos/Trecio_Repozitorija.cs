using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dienynas.Esme;
using Dienynas.Trimestrai;

namespace Dienynas.Trimestrai_Repozitorijos
{
    public class Trecio_Repozitorija
    {
        public List<Trecias_Trimestras> TrecioTrimestroDuomenys { get; set; }
        public Trecio_Repozitorija()
        {
            TrecioTrimestroDuomenys = new List<Trecias_Trimestras>();
            CSV_Getter trecias = new CSV_Getter();
            var data = trecias.CSVGetter(@"C:\Users\Emilija\Desktop\Trimestrai\treciasTrimestras.csv.txt");

            foreach (var item in data)
            {
                var grades = new List<int>();

                foreach (var number in item[2].Split(','))
                {
                    grades.Add(int.Parse(number));
                }

                TrecioTrimestroDuomenys.Add(new Trecias_Trimestras
                {
                    ID = Convert.ToInt32(item[0]),
                    FullName = item[1],
                    Grades = grades
                });

            }

        }

        public Trecias_Trimestras Retrive(int id)
        {
            return TrecioTrimestroDuomenys.FirstOrDefault(x => x.ID == id);
        }
        public Trecias_Trimestras RetriveGrades(List<int> grades)
        {
            return TrecioTrimestroDuomenys.FirstOrDefault(x => x.Grades == grades);
        }
        public List<Trecias_Trimestras> Retrive()
        {
            return TrecioTrimestroDuomenys;
        }
        public void MokiniuSarasas()
        {
            foreach (var item in TrecioTrimestroDuomenys)
            {
                Console.WriteLine($"Mokinio ID: {item.ID}, Mokinio Vardas: {item.FullName}");
            }
        }
        public void PridetiPazimi(List<int>grades, int id)
        {
            TrecioTrimestroDuomenys.Add(new Trecias_Trimestras(id, grades));
        }


    }
}
