using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirPort.Repositorys
{
    public class AircraftRepository
    {
        private List<Aircraft> Aircrafts { get; set; }

        public AircraftRepository()
        {
            Aircrafts = new List<Aircraft>();
            Aircrafts.Add(new Aircraft(1, 19, 1, "LY-SPH"));
            Aircrafts.Add(new Aircraft(2, 18, 2, "VQ-BSB"));
            Aircrafts.Add(new Aircraft(3, 17, 3, "VQ-BSA"));
            Aircrafts.Add(new Aircraft(4, 16, 4, "EI-FDL(EX.TC-KLA)"));
            Aircrafts.Add(new Aircraft(5, 15, 5, "UR-CKB"));
            Aircrafts.Add(new Aircraft(6, 14, 6, "PK-BBS"));
            Aircrafts.Add(new Aircraft(7, 13, 7, "PK-BBY"));
            Aircrafts.Add(new Aircraft(8, 12, 8, "PK-BBB"));
            Aircrafts.Add(new Aircraft(9, 11, 9, "TC-KLA"));
            Aircrafts.Add(new Aircraft(10, 10, 10, "EI-FDM"));
            Aircrafts.Add(new Aircraft(11, 9, 11, "EI-ETJ"));
            Aircrafts.Add(new Aircraft(12, 8, 12, "EI-ETH"));
            Aircrafts.Add(new Aircraft(13, 7, 13, "EI-ETK"));
            Aircrafts.Add(new Aircraft(14, 6, 14, "EI-ETL"));
            Aircrafts.Add(new Aircraft(15, 5, 15, "EI-FBV"));
            Aircrafts.Add(new Aircraft(16, 4, 16, "EI-FBF"));
            Aircrafts.Add(new Aircraft(17, 3, 17, "EI-FBH"));
            Aircrafts.Add(new Aircraft(18, 2, 18, "LY-FLH"));
            Aircrafts.Add(new Aircraft(19, 1, 19, "LY-SPA"));
        }
        public AircraftRepository(List<Aircraft> aircrafts)
        {
            Aircrafts = aircrafts;
        }
        public List<Aircraft> Retrieve()
        {
            return Aircrafts;
        }
        public Aircraft RetrieveByID(int id)
        {
            foreach (var aircraft in Aircrafts)
            {
                if (aircraft.Id == id)
                {
                    return aircraft;
                }
            }
            return Aircrafts.FirstOrDefault(ai=>ai.Id==id);
        }

    }

    
}
