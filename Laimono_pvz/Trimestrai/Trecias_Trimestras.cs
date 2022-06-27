using System;
using System.Collections.Generic;
using System.Text;

namespace Dienynas.Trimestrai
{
    public class Trecias_Trimestras : Trimestras
    {
        public Trecias_Trimestras() { }
        public Trecias_Trimestras(int id, List<int> grades)
        {
            ID = id;
            Grades = grades;
        }
        public Trecias_Trimestras(int id, string fullName, List<int> grades)
        {
            ID = id;
            FullName = fullName;
            Grades = grades;
        }
    }
}
