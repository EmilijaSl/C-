using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop_Programe.NewFolder
{
    public class Candie_Repository
    {
      public List<Candie> Candies { get; set;}

        public Candie_Repository()
        {
            Candies = new List<Candie>();
            CSV_Reader candies = new CSV_Reader();
            var data = candies.CSVReader(@"C:\Users\Emilija\Desktop\Produktai\Candies.csv.txt");


            foreach (var item in data)
            {
                Candies.Add(new Candie
                {
                    Name = item[0],
                    Price = Decimal.Parse(item[1]),
                    BarCode = Int32.Parse(item[2]),
                    Weight = Double.Parse(item[3]),
                    Sugar = Double.Parse(item[4])

                }) ;
            }

        }
        public Candie Retrive(int barCode)
        {
            return Candies.FirstOrDefault(x => x.BarCode == barCode); //grazina tik tuos kurie atitinka salyga
        }

        public List<Candie> Retrive()
        {
            return Candies;
        }

    }
   
}
