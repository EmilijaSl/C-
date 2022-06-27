using System;
using System.Collections.Generic;
using System.Text;

namespace Egzaminas_Dienynas
{
    class CSV_Generatorius
    {
        public List<string[]> CSVGeneratorius(string path)
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
