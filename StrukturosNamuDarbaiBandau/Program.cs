using System;
using System.Collections.Generic;
using System.Linq;

namespace StrukturosNamuDarbaiBandau
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 uzduotis
            //Mokinys mokinys;
            //mokinys.Vardas = "Emilija";
            //mokinys.Pavarde = "Sliburiene";
            //mokinys.KursoPradzia = new DateTime(2022, 01, 01);
            //mokinys.KursoPabaiga = new DateTime(2022, 12, 01);

            //mokinys.InformacijaApieMokini();

            //Mokinys mokinys1 = new Mokinys("Ramunas", "Sliburis", new DateTime(2022, 01, 01), new DateTime(2022, 02, 02));
            //mokinys1.InformacijaApieMokini();

            // 2 uzduotis
            //BibliotekosKnyga bibliotekosKnyga;
            //bibliotekosKnyga.ID = 987654321;
            //bibliotekosKnyga.Pavadinimas = "Valstybe";
            //bibliotekosKnyga.SkaitytojoVardas = "Emilija";
            //bibliotekosKnyga.PaemimoData = new DateTime(1994, 12, 07);
            //bibliotekosKnyga.DabartineData = new DateTime(2022, 04, 02);

            //bibliotekosKnyga.InformacijaApieKnyga();

            //BibliotekosKnyga bibliotekosKnyga1 = new BibliotekosKnyga(123456789, "Trys parsiukai", "Vytis", new DateTime(2022, 03, 25), new DateTime(2022, 04, 04));
            //bibliotekosKnyga1.InformacijaApieKnyga();

            //3 uzduotis


            //Staciakampis staciakampis = new Staciakampis(7, 15);
            //staciakampis.Plotas();

            //Staciakampis staciakampis1 = new Staciakampis(19, 2);
            //staciakampis1.Plotas();

            //Staciakampis staciakampis2 = new Staciakampis(9, 12);
            //staciakampis1.Plotas();

            //4 uzduotis
            //List<Studentas> StudentasList = new List<Studentas>();

            //StudentasList.Add(new Studentas(1, true));
            //StudentasList.Add(new Studentas(2, false));
            //StudentasList.Add(new Studentas(3, true));
            //StudentasList.Add(new Studentas(4, false));
            //StudentasList.Add(new Studentas(5, true));


            //5 uzduotis
            //Studente studente;
            //studente.Semestras1 = new List<int> { 5, 6, 9, 10, 9, 10 };
            //studente.Semestras2 = new List<int> { 7, 8, 9, 10, 7, 8 };
            //studente.Semestras3 = new List<int> { 8, 9, 10, 7, 6, 10 };

            //double pirmas = studente.Vidurkis1();
            //double antras = studente.Vidurkis2();
            //double trecias = studente.Vidurkis3();

            //Console.WriteLine($"Pirmo {pirmas}\n Antro{antras}\n Trecio{trecias}");

            //double metinis = studente.Metinis(pirmas, antras, trecias);

            //6 uzduotis

            //List<Rinkejas> rinkejai = new List<Rinkejas>();

            //var rnd = new Random();

            //for (int i = 0; i < 10; i++)
            //{
            //    rinkejai.Add(new Rinkejas(rnd.Next(5000, 6000), rnd.Next(2) == 0));
            //}
            //int sumUz = 0;
            //int sumPries = 0;

            //foreach (var rinkejas in rinkejai)
            //{
            //    if (rinkejas.Balsas == false)
            //    {
            //        sumUz = sumUz + 1;
            //    }

            //    if (rinkejas.Balsas == true)
            //    {
            //        sumPries = sumPries + 1;
            //    }
            // rinkejas.RinkejoStatistika();

            //}
            //Console.WriteLine($"Rinkeju balsavusiu uz yra {sumUz}\nRinkeju balsavusiu pries yra {sumPries}");


            //7 uzduotis
            //Gyvunas gyvunas1 = new Gyvunas("Labradoras", "Canis Lupus");
            //Gyvunas gyvunas2 = new Gyvunas("Rotveileris", "Canis Lupus");
            //Gyvunas gyvunas3 = new Gyvunas("Ciau Ciau", "Canis Lupus");
            //Gyvunas gyvunas4 = new Gyvunas("Persu", "Felis Catus");
            //Gyvunas gyvunas5 = new Gyvunas("Meino Meskenas", "Felis Catus");

            //List<Gyvunas> GyvunuListas = new List<Gyvunas> { gyvunas1, gyvunas2, gyvunas3, gyvunas4, gyvunas5 };

            //ZoologijosSodas zoologijosSodas = new ZoologijosSodas("Kauno Zoologijos sodas", "Kaunas", GyvunuListas);

            //zoologijosSodas.GyvunuS();

            //8.1
            //Student student;

            //student.Trimestras1 = new List<int> {5, 6 , 7, 8, 9, 10 };
            //student.Trimestras2 = new List<int> {9, 8,7,2,3,10 };
            //student.Trimestras3 = new List<int> {10,9,7,6,8,10 };

            //double vidurkis1 = student.PirmoTrimestroVidurkis();
            //double vidurkis2 = student.AntroTrimestroVidurkis();
            //double vidurkis3 = student.TrecioTrimestroVidurkis();
            //double Metin = student.MetinisBalas(vidurkis1, vidurkis2, vidurkis3);
            //Console.WriteLine("Pirmo trimestro vidurkis: " +vidurkis1+"\nAntro trimestro vidurkis: " +vidurkis2+ "\nTrecio trimestro vidurkis: " + vidurkis3+ "\nMetinis balas: " + Metin);

            //8.2
            Saskaita saskaita;
            List<Saskaita>VisosSaskaitos = new List<Saskaita>();
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                VisosSaskaitos.Add(new Saskaita(rand.Next(1000000, 9000000), rand.Next(1000, 5000)));
                
            }
            foreach(var viso in VisosSaskaitos)
            Console.WriteLine(viso);
            

            //for (int i = 0; i < VisosSaskaitos.Count; i++)
            //{
            //    Console.WriteLine(VisosSaskaitos[]);
            //}

              












        }
    }
}


