using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop_Programe.NewFolder
{
    public class Meat_Repository
    {
        public List<Meat> Meats { get; set; }

        public Meat_Repository()
        {
            Meats = new List<Meat>();
            CSV_Reader meats = new CSV_Reader();
            var data = meats.CSVReader(@"C:\Users\Emilija\Desktop\Produktai\Meats.csv.txt");


            foreach (var item in data)
            {
                Meats.Add(new Meat 
                {
                Name = item[0],
                Price = Convert.ToDecimal(item[1]),
                BarCode = Convert.ToInt32(item[2]),
                Weight = Convert.ToDouble(item[3]),
                Carbs = Convert.ToDouble(item[4])
                 });
            }

        }
        public Meat Retrive(int barCode)
        {
            return Meats.FirstOrDefault(x => x.BarCode == barCode); //grazina tik tuos kurie atitinka salyga
        }

        public List<Meat> Retrive()
        {
            return Meats;
        }
        
       
    }
   
}
