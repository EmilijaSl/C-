using System;
using System.Collections.Generic;
using System.Text;
using AirPort.Repositorys;

namespace AirPort
{
    public class ReportItem
    {
        public string AircraftTailNumber { get; set; } //aircraft
        public string MOdelNumber { get; set; } //model
        public string ModelDescription { get; set; } //model
        public string OwnerCompanyName { get; set; } //company
        public string CompanyCountryCode { get; set; } //country
        public string CompanyCountryName { get; set; } //country
        public bool BelongsToEu { get; set; }

        public ReportItem(string aircraftTailNumber, string modelNumber, string modelDescrioption, string ownerCompanyName, string companyCountryCode, string companyCountryName)
        {
            AircraftTailNumber = aircraftTailNumber;
            MOdelNumber = modelNumber;
            ModelDescription = modelDescrioption;
            OwnerCompanyName = ownerCompanyName;
            CompanyCountryCode = companyCountryCode;
            CompanyCountryName = companyCountryName;
        }



        //List<ReportItem> GenerateReportAircraftEurope = new List<ReportItem>();


    }
}
