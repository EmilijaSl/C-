using System;
using System.Collections.Generic;
using System.Text;
using Dienynas.Trimestrai;
using Dienynas.Trimestrai_Repozitorijos;

namespace Dienynas.Esme
{
   public class TrimestroVidurkioSkaiciuokle
    {
        Pirmo_Repozitorija Pirmo_Repozitorija { get; set; }
        Antro_Repozitorija Antro_Repozitorija { get; set; }
        Trecio_Repozitorija Trecio_Repozitorija { get; set; }

        public TrimestroVidurkioSkaiciuokle() { }

        public TrimestroVidurkioSkaiciuokle(Pirmo_Repozitorija pirmo_Repozitorija, Antro_Repozitorija antro_Repozitorija, Trecio_Repozitorija trecio_Repozitorija)
        {
            Pirmo_Repozitorija = pirmo_Repozitorija;
            Antro_Repozitorija = antro_Repozitorija;
            Trecio_Repozitorija = trecio_Repozitorija;
        }

        public void Dienynas()
        {
            Console.WriteLine("Laba diena, Tamo.lt jungiasi");
            bool repeat = true;
            string userInput;

            while (repeat)
            {
                Console.Clear();
                Console.WriteLine("MENIU\n[1] - Ivesti pazimi\n[2] - Perziureti pazymius\n[3] - Trimestro vidurkis\n[4] - Metinis vidurkis\n[5] - Iseiti");
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        break;
                }
            }
        }
        //private void PirmoTrimestroPazymiai(int id)
        //{
        //    foreach (var balas in Pirmo_Repozitorija.Retrive())
        //    { 
        //    if (balas.ID== )
        //    }
        //}
        public void PridetiPazymi()
        {
            Console.WriteLine("Iveskite studento ID");
        
        }
    }

}
