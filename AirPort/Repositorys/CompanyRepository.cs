using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirPort.Repositorys
{
    public class CompanyRepository  //susikuriam nauja klase 
    {
        private List<Company> Companies { get; set; }  //sukuriame nauja sarasa kuris susides is company duomenu. Pavadinam companies (nes toks yra jau duotas)
        //realiai sukuriame sarasa i kuri pridedame parametrus sukurtus Company konstrukte. 
        public CompanyRepository() //naujas vietinis konstruktas
        {
            Companies = new List<Company>(); //pirma reikia inicializuoti lista, kitaip nepavyks prideti duomenu.
            //List<AircraftModel> AircraftMOdels = new List<AircraftModel>(); - cia butu naujo listo sukurimas, o virsuje INICIALIZAVIMAS
            Companies.Add(new Company(1, "Grand Enterprises O.L Ltd.", 1));
            Companies.Add(new Company(2, "AV-EX AVIATION EXCELLENCE", 2));
            Companies.Add(new Company(3, "AVIA TECHNIQUE LTD.", 3));
            Companies.Add(new Company(4, "Aviall Services Inc.", 4));
            Companies.Add(new Company(5, "Air Atlanta Aviaservices LIMITED", 5));
            Companies.Add(new Company(6, "AVIATION EXCESS INC.", 6));
            Companies.Add(new Company(7, "AVIATION GRAPHIX  LTD", 7));
            Companies.Add(new Company(8, "AVIATION POWER INC.", 8));
            Companies.Add(new Company(9, "AVIATION SUPPORT EUROPE", 9));
            Companies.Add(new Company(10, "AVIATRONICS, INC.", 10));
            Companies.Add(new Company(11, "AVIO-DIEPEN B.V.", 11));
            Companies.Add(new Company(12, "AVION SYSTEMS, INC.", 12));
            Companies.Add(new Company(13, "AVIONIK STRAUBING VERTRIEBS UND SERVICE", 13));
            Companies.Add(new Company(14, "AVIOSERV SAN DIEGO, INC.", 14));
            Companies.Add(new Company(15, "AVIOSUPPORT", 15));
            Companies.Add(new Company(16, "Aircraft Support and Services, Inc.", 16));
            Companies.Add(new Company(17, "BIAERO, LLC", 17));
            Companies.Add(new Company(18, "BIC CARPETS", 18));
            Companies.Add(new Company(19, "BIGGLES LABELLING LIMITED", 19));
            Companies.Add(new Company(20, "BILL THOMAS ASSOCIATES, INC.", 20));
            Companies.Add(new Company(21, "WILSON AVIATION SERVICES", 21));
            Companies.Add(new Company(22, "BOMBARDIER AEROSPACE", 22));
            Companies.Add(new Company(23, "BOTRON COMPANY INC.", 23));
            Companies.Add(new Company(24, "BOURNEMOUTH AVIATION (CONSULTANTS) LTD.", 24));
            Companies.Add(new Company(25, "Magnetic MRO AS", 25));
            Companies.Add(new Company(26, "BP OIL INTERNATIONAL LTD", 26));
            Companies.Add(new Company(27, "BRESLIN AEROTECH, LLC", 27));
            Companies.Add(new Company(28, "BRIDGES NDT", 28));
            Companies.Add(new Company(29, "BRIDGESTONE AIRCRAFT TIRE", 29));
            Companies.Add(new Company(30, "BRITANNIA AIRWAYS", 30));
        }

        public List<Company> Retrive() //sugrazina visa sarasa
        {
            return Companies;
        }
        public Company RetriveById(int id) // sukurim metoda, kuris paima companies pagal id ir pagrazina. Dar paprasciau paima pasirinkta eilute pagal ID
        {
            return Companies.FirstOrDefault(co => co.Id == id); //Single... grazina tik tuos, kurie atitinka salygas; 
        }
      
    }
}

