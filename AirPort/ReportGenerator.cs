using System;
using System.Collections.Generic;
using System.Text;
using AirPort.Repositorys;

namespace AirPort
{
    public class ReportGenerator
    {
       private CompanyRepository CompanyRepository { get; set; } //taip pasigrazinam repozitoriju klases i nauja klase, jog galetume disponuoti duomenimis. 
       private AircraftModelRepository AircraftModelRepository { get; set; } //cia yra properciai in general, veliau juos paduodam i konstruktoriu
       private CountryRepository CountryRepository { get; set; }
       private AircraftRepository AircraftRepository { get; set; }

        public ReportGenerator() { }  //PAKLAUSK KAM REIKIA TUSCIO KONSTRUKTORIAUS? 
        public ReportGenerator(CompanyRepository companyRepository, AircraftModelRepository aircraftModelRepository, CountryRepository countryRepository, AircraftRepository aircraftRepository)
        {//o taip paduodam jas i konstruktoriu
            CompanyRepository = companyRepository;
            AircraftModelRepository = aircraftModelRepository;
            CountryRepository = countryRepository;
            AircraftRepository = aircraftRepository;
        }

        public List<ReportItem> GenerateReportAircraftEurope()
        {
            var EUAircrafts = new List<ReportItem>(); //sukuriam lista report iteme lektuvu, kurie is Europos
            var AllAircrafts = AircraftRepository.Retrieve(); //pacallinam metoda, paimti visu lektuvu sarasa is AicraftRep. 
            
            foreach (var aircraft in AllAircrafts) //pereiname(iteruojame) per visu lektuvu sarasa
            {
                var company = CompanyRepository.RetriveById(aircraft.CompanyId); //Paimame lektuvo kompanija. kiekvienas lektuvas turi company ID. Su tuo Company ID kvieciame Company repozitorija. Callinam metoda retrieve by id. Mum grazina kompanija, kurioje yra country ID, kuri ir pasiimame. 
                var country = CountryRepository.RetriveById(company.CountryId); // Su Kompanijos Country ID kreipiames i country reppozitorija. Su country ID einame per country repozitorija, tam, kad pagrazintu sali. 
                var model = AircraftModelRepository.RetriveById(aircraft.ModelId); 
                //pirma per lektuvus. 
                if (country.Continent == "Europe")
                {
                    EUAircrafts.Add(new ReportItem(aircraft.TailNumber, model.Number, model.Description, company.Name, country.Code, country.Name)); //pridedame tai, ka sukureme report item class
                    
                }
             
            }
            return EUAircrafts;


        }
        public List<ReportItem> GenerateReportAircraftOther()
        {
            var OtherAircrafts = new List<ReportItem>(); //Captain obvious cia Neeuropietiskiem
            var AllAircrafts = AircraftRepository.Retrieve();
            foreach (var aircraft in AllAircrafts)
            {
                var company = CompanyRepository.RetriveById(aircraft.CompanyId);
                var country = CountryRepository.RetriveById(company.CountryId);
                var model = AircraftModelRepository.RetriveById(aircraft.ModelId);
                if (country.Continent != "Europe")
                {
                    OtherAircrafts.Add(new ReportItem(aircraft.TailNumber, model?.Number, model?.Description, company.Name, country.Code, country.Name)); //jeigu grazina nulla ir meta klaida, tai reikia uzdeti klaustuka 
                }

            }

            return OtherAircrafts;
        }
        

    }
}
