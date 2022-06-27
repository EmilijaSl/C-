using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ExceptionHandling
{
    class FileReader
    {
        public static List<string[]> GetFileLines(string file)
        {
            var reader = new StreamReader(file);

            List<string[]> list = new List<string[]>();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                string[] values = line.Split(';');
                list.Add(values);
            }
            return list;
        }
    }
}
