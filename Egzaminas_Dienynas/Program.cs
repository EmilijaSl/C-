using System;
using Egzaminas_Dienynas.Repozitorijos;

namespace Egzaminas_Dienynas
{
    class Program
    {
        static void Main(string[] args)
        {
            var dienynas = new Dienynas(new Pazymiai_Repozitorija(), new Mokiniai_Repozitorija());
            dienynas.DienynasPagrindinis();
        }
    }
}
