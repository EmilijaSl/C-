using System;
using System.Collections.Generic;
using System.Text;

namespace AirPort
{
    public class Country
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Continent { get; set; }
        public bool BelongsToEu { get; set; }

        public Country(int id, string code, string name, string continent, bool belongsToEu)
        {
            Id = id;
            Code = code;
            Name = name;
            Continent = continent;
            BelongsToEu = belongsToEu;
        }
    }
}
