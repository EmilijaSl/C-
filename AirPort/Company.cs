using System;
using System.Collections.Generic;
using System.Text;

namespace AirPort
{
    public class Company //tam, kad galetume panaudoti repozitorijoje sitos klases duomenis klase turi buti public - public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }

        public Company(int id, string name, int countryId)
        {
            Id = id;
            Name = name;
            CountryId = countryId;
        }
        
    }

}
