using System;
using System.Collections.Generic;
using System.Text;

namespace Dienynas.Trimestrai
{
    public class Antras_Trimestras : Trimestras
    {
        public Antras_Trimestras() { }
        public Antras_Trimestras(int id, string fullName, List<int> grades)
        {
            ID = id;
            FullName = fullName;
            Grades = grades;
        }
    }
}
