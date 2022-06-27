using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop_Programe.NewFolder
{
    public class Vegetable_Repository
    {
        public List<Vegetable> Vegetables  { get; set; }

        public Vegetable_Repository()
        {
            Vegetables = new List<Vegetable>();
            CSV_Reader vegetables = new CSV_Reader();

            var data = vegetables.CSVReader(@"C:\Users\Emilija\Desktop\Produktai\Vegetables.csv.txt");

            foreach (var item in data)
            {

                Vegetables.Add(new Vegetable
                {
                    Name = item[0],
                    Price = Convert.ToDecimal(item[1]),
                    BarCode = Convert.ToInt32(item[2]),
                    Weight = Convert.ToDouble(item[3]),
                    Fibers = Convert.ToDouble(item[4]),
                    
                }); 
            }
        }
        public Vegetable Retrive(int barCode)
        {
            return Vegetables.FirstOrDefault(x => x.BarCode == barCode); //grazina tik tuos kurie atitinka salyga
        }

        public List<Vegetable> Retrive()
        {
            return Vegetables;
        }
    }
}
