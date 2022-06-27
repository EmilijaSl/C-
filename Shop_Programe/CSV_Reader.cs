using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.IO;
using Shop_Programe.NewFolder;

namespace Shop_Programe
{
    public class CSV_Reader

    {

        public List<string[]> CSVReader(string path) //tokiu budu pridedame areju 
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
