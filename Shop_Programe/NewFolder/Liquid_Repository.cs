using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Shop_Programe.NewFolder
{
    public class Liquid_Repository
    {
        public List<Liquid> Liquids { get; set; }
        public Liquid_Repository()
        {

            Liquids = new List<Liquid>();
            CSV_Reader liquids = new CSV_Reader(); //nurodome kelia is kur paimta, jog galetume naudoti
            var data = liquids.CSVReader(@"C:\Users\Emilija\Desktop\Produktai\Liquids.csv.txt");//kad nurodytume path pries viska reikia padeti @


            foreach (var item in data)
            {
                Liquids.Add(new Liquid
                { 
                Name = item[0],
                Price = Convert.ToDecimal(item[1]),
                BarCode = Convert.ToInt32(item[2]),
                Weight = Convert.ToDouble(item[3]),
                });

            }
          
        }
        public Liquid Retrive(int barCode)
        {
            return Liquids.FirstOrDefault(x => x.BarCode == barCode); //grazina tik tuos kurie atitinka salyga
        }

        public List<Liquid> Retrive()
        {
            return Liquids;
        }
    }
}
