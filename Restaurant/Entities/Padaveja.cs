using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Entities
{
    public class Padaveja
    {
        public int PadavejosID{get;set;}
        public string PadavejosVardas { get; set; }
        public Padaveja() { }
        public Padaveja(int padavejosID, string padavejosVardas)
        {
            PadavejosID = padavejosID;
            PadavejosVardas = padavejosVardas;
        }

    }
}
