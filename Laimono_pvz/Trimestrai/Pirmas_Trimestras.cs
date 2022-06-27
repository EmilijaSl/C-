using System;
using System.Collections.Generic;
using System.Text;

namespace Dienynas.Trimestrai
{
    public class Pirmas_Trimestras : Trimestras
    {
        
        public Pirmas_Trimestras() { }
        public Pirmas_Trimestras(int id, string fullName, List <int> grades)
        {
            ID = id;
            FullName = fullName;
            Grades = grades;

        }
    }
}
