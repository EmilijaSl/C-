using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Dienynas.Esme
{
    class CSV_Getter
    {
        public List<string[]> CSVGetter(string path)
        {
            var reader = new StreamReader(path);
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
