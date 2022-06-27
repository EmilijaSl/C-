using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.OData.Edm;

namespace Structs
{
    public struct Person
    {
        public string Name;
        public string LastName;
        public int Age;

        public Person(string name, string lastname, int age)
        {
            Name = name;
            LastName = lastname;
            Age = age;
        }


        public void SayMyFullName()
        {
            Console.WriteLine($"Vardas {Name} pavarde {LastName} amzius {Age}");
        }

    }

    public struct Pazymiai
    {
        public int PirmasSemestas;
        public int AntrasSemestras;
        public int TreciasSemestras;
        public int MetinisVidurkis;

        public Pazymiai(int semestras1, int semestras2, int semestras3)
        {
            PirmasSemestas = semestras1;
            AntrasSemestras = semestras2;
            TreciasSemestras = semestras3;
            MetinisVidurkis = (semestras1 + semestras2 + semestras3) / 3;



        }

        public void ParasykPa()
        {
            Console.WriteLine($"Pirmo semestro vidurkis - {PirmasSemestas}, antro semestro vidurkis {AntrasSemestras}, trecio semestro vidurkis {TreciasSemestras}");
            Console.WriteLine($"Jusu metinis vidurkis {MetinisVidurkis}");
        }


    }
    public struct Mokinys
    {
        public string Vardas;
        public string Pavarde;
        public DateTime KursoPradzia;
        public DateTime KursoPabaiga;

        public Mokinys(string vardas, string pavarde, DateTime kursoPradzia, DateTime kursoPabaiga)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            KursoPradzia = kursoPradzia;
            KursoPabaiga = kursoPabaiga;

        }

        public void InformacijaApieMokini()
        {
            Console.WriteLine($"Mokinio vardas {Vardas}\n Mokinio pavarde {Pavarde}\n Kursu pradzia {KursoPradzia}\n Kursu pabaiga {KursoPabaiga}");
        }
    }

}


    