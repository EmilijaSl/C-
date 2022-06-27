using System;
using System.Collections.Generic;
using System.Text;

namespace Dienynas.Trimestrai
{
    public class Trimestras
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public List<int> Grades { get; set; }
        public Trimestras() { }
        public Trimestras(int id, string fullName, List<int> grades)
        {
            ID = id;
            FullName = fullName;
            Grades = grades;

        }
    }
}
