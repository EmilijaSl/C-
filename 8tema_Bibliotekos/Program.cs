using System;
using System.Collections.Generic;
using Library;

namespace _8tema_Bibliotekos
{
    class Program
    {
        static void Main(string[] args)
        {
            // #region 8.1 su banko saskaitom
            // Saskaita BankoSaskaita = new Saskaita("Emilija", "Ramas", 100);
            // string israsas = BankoSaskaita.CekioIsrasas();

            // Console.WriteLine("Gavejas - " + BankoSaskaita.receiver + "\nSeiuntejas - " + BankoSaskaita.sender + "\nSiunciama suma:" + BankoSaskaita.pay + "\n Pavedimo cekio duomenys" + israsas);
            // Console.Clear();

            // #endregion
            // #region 8.2 Palme ir kokosai
            //Palme MedisPalme = new Palme(9);
            //MedisPalme.OneMonthPlus();
            // #endregion Palme

            //#region
            Miskas mazasMiskas;
            List<int> PlantedTrees = new List<int>();
            

            mazasMiskas.MedziuSodinimas(13, PlantedTrees);
            //#endregion
        }


    }
}
