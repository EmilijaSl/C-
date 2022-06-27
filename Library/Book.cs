using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    #region 8 tema 1 uzduotis Saskaita
    public struct Saskaita
    {
        public string receiver { get; private set; }
        public string sender { get; private set; }
        public int pay { get; private set; }
        public string accauntNumber { get; private set; }


        public Saskaita(string aReceiver, string aSender, int toPay)
        {
            receiver = aReceiver;
            sender = aSender;
            pay = toPay;
            accauntNumber = string.Empty;
            CekioIsrasas();

        }

        public string CekioIsrasas()
        {
            string israsas = "";
            DateTime today = new DateTime(2022, 07, 04);
            israsas = "NR_" + today + "01";
            return israsas;
        }

    }
    #endregion
    #region 8 tema 2 uzduotis Palme
    //public struct Palme
    //{

    //    public int Age { get; private set; }


    //    public Palme(int age)
    //    {
    //        Age = age;
    //    }

    //    public void OneMonthPlus()
    //    {

    //        if (Age <= 12)
    //        {
    //            int CocoAge = 0;
    //            int coconutfruit = 0;
    //            for (int i = 0; i < Age; i++)
    //            {
    //                CocoAge = CocoAge + 1;
    //            }
    //            for (int i = 5; i < Age; i++)
    //            {
    //                if (i >= 6)
    //                {
    //                    coconutfruit = Age * 3;

    //                }

    //            }
    //            Console.WriteLine("Coconut age = " + CocoAge + "fruit count = " + coconutfruit);
    //        }
    //        else
    //        {
    //            Console.WriteLine("Palme numire, sodinkite kita");
    //        }

    //    }

    //}
    #endregion

    #region Miskas
    public struct Miskas
    {
        public static List<int> PlantedTrees{get; private set; }

    public Miskas(List<int> plantedTrees)
    {
        PlantedTrees = plantedTrees;
    }
        
    public List<int> MedziuSodinimas(int sodinukai, List<int> listas)
    {
            
            if (sodinukai != 0)

            {
                listas.Add(sodinukai);

                for (int i = 0; i < listas.Count; i++)
                {
                    Console.WriteLine("Pasodintu medziu yra: " + listas[i]);
                }
            }
            else
            {
                Console.WriteLine("Pasodintu medziu nera");
            }
            
            return PlantedTrees;
    }
       


}







    //public void CountTheTree(int tree, List<int> med)
    //{

    //    for (int i = 0; i < tree; i++)
    //    {
    //        med.Add(1);
    //    }
    //    foreach (var sodinys in )
    //    Console.WriteLine("Pasodinta medziu" + med.Count );
    //}


}


    #endregion
