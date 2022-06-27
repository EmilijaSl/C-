
using System;
using System.Collections.Generic;
using System.Linq;

namespace StrukturosNamuDarbaiBandau
{
    #region 1 Uzduotis
    public struct Mokinys
    {
        //cia yra struktura
        public string Vardas;
        public string Pavarde;
        public DateTime KursoPradzia;
        public DateTime KursoPabaiga;

        //o cia yra konstruktas
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
    #endregion
    #region 2 Uzduotis
    public struct BibliotekosKnyga
    {
        public int ID;
        public string Pavadinimas;
        public string SkaitytojoVardas;
        public DateTime PaemimoData;
        public DateTime DabartineData;
        // int knygosPaemimoTerminas = (DabartineData.date - PaemimoData.date).TotalDays;

        public BibliotekosKnyga(int id, string pavadinimas, string skaitytojoVardas, DateTime paemimoData, DateTime dabartineData)
        {
            ID = id;
            Pavadinimas = pavadinimas;
            SkaitytojoVardas = skaitytojoVardas;
            PaemimoData = paemimoData;
            DabartineData = dabartineData;

        }

        public void InformacijaApieKnyga()
        {
            Console.WriteLine($" Knygos ID {ID}\n Knygos Pavadinimas {Pavadinimas}\n Skaitytojo vardas {SkaitytojoVardas}\n Knyga pas skaitytoja yra {(DabartineData - PaemimoData).TotalDays} dienu");
        }

    }
    #endregion
    #region 3 Uzduotis
    public struct Staciakampis
    {
        public int Ilgis;
        public int Plotis;

        public Staciakampis(int ilgis, int plotis)
        {
            Ilgis = ilgis;
            Plotis = plotis;

        }

        public void Plotas()
        {
            int Plotas = Ilgis * Plotis;
            Console.WriteLine($"staciakampio plotas yra: {Plotas}");

        }

    }
    #endregion
    #region 4 Uzduotis
    public struct Studentas
    {

        public int ID;
        public bool Iskaita;
        public Studentas(int id, bool iskaita)
        {
            ID = id;
            Iskaita = iskaita;
            if (iskaita == true)
            {
                Console.WriteLine("Sveikiname, iskaita islaikete");
            }
            if (iskaita == false)
            {
                Console.WriteLine("Iskaita neislaikyta");
            }

        }


    }
    #endregion
    #region 5 Uzduotis
    public struct Studente
    {
        public List<int> Semestras1;
        public List<int> Semestras2;
        public List<int> Semestras3;

        public Studente(List<int> semestras1, List<int> semestras2, List<int> semestras3)
        {
            Semestras1 = semestras1;
            Semestras2 = semestras2;
            Semestras3 = semestras3;

        }

        public double Vidurkis1()
        {
            Console.WriteLine($"Pirmo semestro vidurkis yra: {Semestras1.Average()}");
            return Semestras1.Average();

        }
        public double Vidurkis2()
        {
            Console.WriteLine($"Pirmo semestro vidurkis yra: {Semestras2.Average()}");
            return Semestras2.Average();
        }
        public double Vidurkis3()
        {
            Console.WriteLine($"Pirmo semestro vidurkis yra: {Semestras3.Average()}");
            return Semestras3.Average();
        }
        public double Metinis(double pirmas, double antras, double trecias)
        {
            double met = (pirmas + antras + trecias) / 3;
            Console.WriteLine($"Metinis {met}");
            return met;
        }

    }
    #endregion
    #region 6 Uzduotis
    public struct Rinkejas
    {
        public int ID;
        public bool Balsas;


        public Rinkejas(int id, bool balsas)
        {
            ID = id;
            Balsas = balsas;

        }
        public void RinkejoStatistika()
        {
            Console.WriteLine($"Rinkejo ID {ID}\n Rinkejo balsas {Balsas}");
        }

    }
    #endregion
    #region 7 Uzduotis
    public struct ZoologijosSodas
    {
        public string SodoPavadinimas;
        public string Adresas;
        public List<Gyvunas> GyvunuSarasas;

        public ZoologijosSodas(string sodoPavadinimas, string adresas, List<Gyvunas> gyvunuSarasas)
        {
            SodoPavadinimas = sodoPavadinimas;
            Adresas = adresas;
            GyvunuSarasas = gyvunuSarasas;
        }
        public void GyvunuS()
        {
            int sumCanis = 0;
            int sumCatus = 0;

            Console.WriteLine($"Zoologijos sode yra {GyvunuSarasas.Count} gyvunai");
            foreach (var gyvunas in GyvunuSarasas)
            {
                if (gyvunas.Rusis == "Canis Lupus")
                {
                    sumCanis = sumCanis + 1;
                }
                if (gyvunas.Rusis == "Felis Catus")
                {
                    sumCatus = sumCatus + 1;
                }
            }
            Console.WriteLine($"Sunu Zoologijos sode yra {sumCanis}\nKaciu Zoologijos sode yra {sumCatus}");
        }
    }
    public struct Gyvunas
    {
        public string GyvunoVardas;
        public string Rusis;

        public Gyvunas(string gyvunoVardas, string rusis)
        {
            GyvunoVardas = gyvunoVardas;
            Rusis = rusis;
        }
    }
    #endregion
    #region 8 tema 1 uzduotis
    public struct Student
    {
        public List<int> Trimestras1;
        public List<int> Trimestras2;
        public List<int> Trimestras3;

        public Student(List<int> trimestras1, List<int> trimestras2, List<int> trimestras3)
        {
            Trimestras1 = trimestras1;
            Trimestras2 = trimestras2;
            Trimestras3 = trimestras3;
        }

        public void GenerateRandomNumbers(List<int> trimestras)
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                trimestras.Add(random.Next(1, 10));
            }
        }
        public int PirmoTrimestroVidurkis()
        {
            int trimestroPazimiuSuma = 0;
            foreach (var balas in Trimestras1)
            {
                trimestroPazimiuSuma = trimestroPazimiuSuma + balas;
            }
            trimestroPazimiuSuma = trimestroPazimiuSuma / Trimestras1.Count;
            return trimestroPazimiuSuma;
        }

        public int AntroTrimestroVidurkis()
        {
            int trimestroPazimiuSuma = 0;
            foreach (var balas in Trimestras2)
            {
                trimestroPazimiuSuma = trimestroPazimiuSuma + balas;
            }
            trimestroPazimiuSuma = trimestroPazimiuSuma / Trimestras2.Count;
            return trimestroPazimiuSuma;
        }

        public int TrecioTrimestroVidurkis()
        {
            int trimestroPazimiuSuma = 0;
            foreach (var balas in Trimestras3)
            {
                trimestroPazimiuSuma = trimestroPazimiuSuma + balas;
            }
            trimestroPazimiuSuma = trimestroPazimiuSuma / Trimestras3.Count;
            return trimestroPazimiuSuma;
        }

        public double MetinisBalas(double vid, double vid2, double vid3)
        {
            double metinis = (vid + vid2 + vid3) / 3;
            return metinis;
        }



    }
    #endregion
    #region 8 tema 2 uzduotis
    public struct Saskaita
    {
        public int SaskNr;
        public int Viso;

        public Saskaita(int saskNr, int viso)
        {
            SaskNr = saskNr;
            Viso = viso;

        }
        public void SaskaituSarasas(List<Saskaita> VisosS)
        {
            Console.WriteLine("Saskaitos numeris" + SaskNr + "\nSuma saskaitoje" + Viso);
        }
    }
    
    
    public struct Buhalterija
    {
        public List<Saskaita> VisosSaskaitos;
    }
    #endregion
}












