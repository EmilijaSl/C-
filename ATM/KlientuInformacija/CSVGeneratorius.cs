using System;
using System.Collections.Generic;
using System.Text;

namespace ATM.KlientuInformacija
{
    public class CSVGeneratorius
    {
        public List<string[]> CSV_Generatorius(string path)
        {
            var reader = new System.IO.StreamReader(path);
            List<string[]> data = new List<string[]>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                string[] values = line.Split(';');
                data.Add(values);
            }
            return data;
            
        }
        
    }
}
