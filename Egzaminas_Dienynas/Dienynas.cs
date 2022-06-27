using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Egzaminas_Dienynas.Repozitorijos;

namespace Egzaminas_Dienynas
{
    public class Dienynas
    {
        Pazymiai_Repozitorija Pazymiai_Repozitorija { get; set; }
        Mokiniai_Repozitorija Mokiniai_Repozitorija { get; set; }
        public object pazymiai_Repozitorija { get; set; }

        public Dienynas() { }
        public Dienynas(Pazymiai_Repozitorija pazymiai_Repozitorija, Mokiniai_Repozitorija mokiniai_Repozitorija)
        {
            Pazymiai_Repozitorija = pazymiai_Repozitorija;
            Mokiniai_Repozitorija = mokiniai_Repozitorija;
        }

        public void DienynasPagrindinis()
        {
            Console.WriteLine("Laba diena, Tamo.lt jungiasi");
            Console.ReadLine();
            bool repeat = true;
            string userInput;

            while (repeat)
            {
                Console.Clear();
                Console.WriteLine("MENIU\n[1] - Ivesti pazimi\n[2] - Perziureti pazymius\n[3] - Trimestro vidurkis\n[4] - Ataskaita\n[5] - Iseiti");
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        PridetiPazymi();
                        break;

                    case "2":
                        Console.Clear();
                        TrimestruPazymiai();
                        break;
                    case "3":
                        Console.Clear();
                        VidurkioMeniu();
                        break;
                    case "4":
                        Console.Clear();
                        Ataskaita();
                        break;
                    case "5":
                        Console.Clear();
                        repeat = false;
                        break;

                }
            }
        }
        public void PridetiPazymi()
        {
            Console.WriteLine("Iveskite pazymi");
            int balas = Int32.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Iveskite mokinio ID");
            Mokiniai_Repozitorija.MokiniuSarasas();
            int id = Int32.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Iveskite trimestra (1,2,3)");
            int trimestras = Int32.Parse(Console.ReadLine());

            Pazymiai_Repozitorija.PridetiPazymi(balas, id, trimestras);

        }
        public void VisuPazymiuSuvestine()
        {
            Console.WriteLine("Iveskite mokinio ID, kurio pazymius norite pamatyti");
            Mokiniai_Repozitorija.MokiniuSarasas();
            var input = Convert.ToInt32(Console.ReadLine());
            var asmeniniaiPazymiai = Pazymiai_Repozitorija.RetriveID(input);
            foreach (var pazymys in asmeniniaiPazymiai)
            {

                Console.Write($"{pazymys.Balas}");
            }

        }
        public void TrimestruPazymiai()
        {
            Console.WriteLine("Iveskite mokinio ID, kurio pazymius norite pamatyti");
            Mokiniai_Repozitorija.MokiniuSarasas();
            var mokinioID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite trimestra, kurio pazymius norite pamatyti");
            var trimestroNr = Convert.ToInt32(Console.ReadLine());

            var result = Pazymiai_Repozitorija.RetriveTrimestras(trimestroNr, mokinioID);
            foreach (var pazymiai in result)
            {
                Console.WriteLine($"{pazymiai.Balas}");
            }

            Console.ReadLine();

        }

        public List<int> PazymiuSkaitinisSarasasTrimestrui(int id, int trimestras)
        {
            List<int> SkaitinisSarasas = new List<int>();
            foreach (var item in Pazymiai_Repozitorija.Retrive())
            {
                if (item.ID == id && item.Trimestras == trimestras)
                {
                    SkaitinisSarasas.Add(item.Balas);

                }

            }
            return SkaitinisSarasas;
        }

        public List<int> PazymiuSkaitinisSarasasMetiniam(int id)
        {
            List<int> SkaitinisSarasas = new List<int>();
            foreach (var item in Pazymiai_Repozitorija.Retrive())
            {
                if (item.ID == id)
                {
                    SkaitinisSarasas.Add(item.Balas);

                }

            }
            return SkaitinisSarasas;
        }
        public void VidurkioMeniu()
        {
            Console.WriteLine("Iveskite mokinio ID, kurio vidurki norite pamatyti");
            Mokiniai_Repozitorija.MokiniuSarasas();
            var ID = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("[1] - pirmo trimestro vidurkis\n[2] - antro trimestro vidurkis\n[3] - trecio trimestro vvidurkis\n[4] - metinis vidurkis");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    Console.Clear();
                    var vid1 = PazymiuSkaitinisSarasasTrimestrui(ID, 1).Average();
                    Console.WriteLine(vid1);
                    Console.ReadLine();
                    break;
                case "2":
                    Console.Clear();
                    var vid2 = PazymiuSkaitinisSarasasTrimestrui(ID, 3).Average();
                    Console.WriteLine(vid2);
                    Console.ReadLine();
                    break;
                case "3":
                    Console.Clear();
                    var vid3 = PazymiuSkaitinisSarasasTrimestrui(ID, 3).Average();
                    Console.WriteLine(vid3);
                    Console.ReadLine();
                    break;
                case "4":
                    Console.Clear();
                    var met = PazymiuSkaitinisSarasasMetiniam(ID).Average();
                    Console.WriteLine(met);
                    Console.ReadLine();
                    break;




            }


        }
    
        public void Ataskaita()
        {
            Console.WriteLine("Iveskite mokinio ID, kurio ataskaita norite pamatyti");
            Mokiniai_Repozitorija.MokiniuSarasas();
            int id = Int32.Parse(Console.ReadLine());
            var mokinys1 = Mokiniai_Repozitorija.RetriveID1(id);

            var pazymiai = Pazymiai_Repozitorija.RetriveID(id);
            string ataskaita = $"Mokinio duomenys {mokinys1.Vardas}\nMetinis vidurkis:{PazymiuSkaitinisSarasasMetiniam(id).Average()}\nPazymiai:";
            foreach (var pazymys in pazymiai)
            {
                ataskaita += $"{pazymys.Balas}, ";
            }
            
            

            var FilePath = (@"C:\Users\Emilija\Desktop\Trimestrai\Ataskaita.csv.txt");
            using (StreamWriter writer = new StreamWriter(new FileStream(FilePath,
            FileMode.Create, FileAccess.Write)))
            {
                writer.WriteLine(ataskaita);
            }
        }
    }
}

