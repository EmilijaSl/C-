using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ATM.KlientuInformacija
{
    public class Transakciju_Repozitorija 
    {
        public List<Transakcijos> transakcijos { get; set; }
        public Transakciju_Repozitorija()
        {
            transakcijos = new List<Transakcijos>();
            string fileName = @"C:\Users\Emilija\Desktop\Trimestrai\Ataskaita.csv.txt";

            //foreach (var item in transakcijos)
            //{
            //    item.WriteToFile(fileName);
            //}

            //foreach (var item in data)
            //{
            //    transakcijos.Add(new Transakcijos
            //    {
            //        PIN = Int32.Parse(item[0]),
            //        TransakcijosSuma = decimal.Parse(item[1]),
            //        TransakcijosData = DateTime.Parse(item[2])
            //    });
            //}
            take 5 
        }
    }
}
