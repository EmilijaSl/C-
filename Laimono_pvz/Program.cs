using System;
using Dienynas.Esme;
using Dienynas.Trimestrai_Repozitorijos;

namespace Dienynas
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new TrimestroVidurkioSkaiciuokle(new Pirmo_Repozitorija(), new Antro_Repozitorija(), new Trecio_Repozitorija());
            test.Dienynas();

        }
    }
}
