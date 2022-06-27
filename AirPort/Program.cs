using System;
using System.Collections.Generic;
using AirPort.Repositorys;

namespace AirPort
{
    public class Program
    {
        static void Main(string[] args)
        {
            var repGen = new ReportGenerator(new CompanyRepository(), new AircraftModelRepository(), new CountryRepository(), new AircraftRepository());
            repGen.GenerateReportAircraftEurope();
            repGen.GenerateReportAircraftOther(); //jau surinkti lektuvu sarasai pagal Report item kriterijus, sukurti report generatoriuje
            var htmlFormatter = new HTML_formater(); //negalima callinti tol, kol nera aisku is kur duomenys. 
            var reportItems = repGen.GenerateReportAircraftEurope(); // HTML format. paduodame surinktus duomenis is kuriu darys lentele duhhh...
            var reportItems1 = repGen.GenerateReportAircraftOther();
            var htmlString = htmlFormatter.FormatHTML(reportItems);
            Console.WriteLine(htmlString);

            
            
        }
    }
}

            
        
