using System;
using System.Linq;

namespace metodai_uzduotys
{
    class Program
    {
        static void Main(string[] args)
        {

            //WriteName(GetName()); //isveda i konsole varda tiek kartu kiek paprasai

            //Sakinys(); // papraso ivesti sakini ir isveda visas raides kaip groteles

            //KMI(); //Apsakiciuoja kuno mases indeksa

            //Tarpamatis(); //Skaiciuoja kiek tarpu yra eiluteje
            //SkaiciuVirsaitis();
            Kelikas();// xujovai veikia pasitikrink pamokoje
        }
        public static string GetName()
        {
            Console.WriteLine("Iveskite savo varda");
            string name = Console.ReadLine();
            return name;
        }

        public static void WriteName(string name)
        {
            
 
            Console.WriteLine($"Kiek kartu uzrasyti?");
            int howMany = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < howMany; i++)
            {
                Console.Write(name);
            }
            Console.WriteLine();

        }
        
        public static void Sakinys()
        {
            Console.WriteLine("iveskite sakini");
            string sakinys = Console.ReadLine();
            string simbolis = "#";
            {
                
                int sakinioIlgis = sakinys.Length;
                sakinioIlgis = Convert.ToInt32(sakinioIlgis);
                for (int i = 0; i < sakinioIlgis; i++)
                {
                    Console.Write(simbolis);
                }
               
            }
            Console.WriteLine();
            

        }
   
        public static void KMI()
        {
            Console.WriteLine("Iveskite savo svori");
            decimal svoris = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("iveskite savo ugi ");
            decimal ugis = Convert.ToInt32(Console.ReadLine());

            decimal ugisMetrais = ugis / 100;

            decimal KunoMasesIndeksas = svoris / (ugisMetrais*ugisMetrais);

            if (KunoMasesIndeksas < 18)
            {
                Console.WriteLine($"Jusu kuno mases indeksas yra:{KunoMasesIndeksas} - sveriate per mazai");
            }
            else if (KunoMasesIndeksas < 30)
            {
                Console.WriteLine($"Jusu kuno mases indeksas yra:{KunoMasesIndeksas} - svoris normalus");
            }
            else if (KunoMasesIndeksas > 30)
            { 
               Console.WriteLine($"Jusu kuno mases indeksas yra:{KunoMasesIndeksas} nutukote mielasis");
            }
             

            
            

        }

        public static void Tarpamatis()
        {
            Console.WriteLine("Iveskite sakini");
            string sakinys = Console.ReadLine();
            int countSpaces = sakinys.Count(Char.IsWhiteSpace);
            Console.Write($"Tarpu skaicius eiluteje yra:{countSpaces}");

        }
        //public static void SkaiciuVirsaitis()
        //{
        //    Console.WriteLine("Iveskite norima skaiciu");
        //    int ivestasSkaicius = Convert.ToInt32(Console.ReadLine());
        //    int sum = 0;

        //    for (int i = 0; i < ivestasSkaicius.Length; i++)
        //    {
        //        sum += ivestasSkaicius[i];
        //        Console.WriteLine($"Skaiciu suma yra {sum)");
        //    }
        //    Console.WriteLine();
        //}
        public static void Kelikas()
        {
            Console.WriteLine("Iveskite skaiciu, kuri norite pakelti");
            int skaicius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite skaiciu, kuriuo norite pakelti");
            int skaiciusKelejas = Convert.ToInt32(Console.ReadLine());

            int kvadratas;

            if (skaiciusKelejas == 2)
            {
                kvadratas = skaicius * skaiciusKelejas * skaiciusKelejas;
                Console.WriteLine($"Jusu skaicius yra: {kvadratas}");
            }
            else if(skaiciusKelejas==3)
            {
                kvadratas = skaicius * skaiciusKelejas * skaiciusKelejas * skaiciusKelejas;
                Console.WriteLine($"Jusu skaicius yra: {kvadratas}");
            }
            else if (skaiciusKelejas == 4)
            {
                kvadratas = skaicius * skaiciusKelejas * skaiciusKelejas * skaiciusKelejas* skaiciusKelejas;
                Console.WriteLine($"Jusu skaicius yra: {kvadratas}");
            }
            else if (skaiciusKelejas == 5)
            {
                kvadratas = skaicius * skaiciusKelejas * skaiciusKelejas * skaiciusKelejas* skaiciusKelejas * skaiciusKelejas;
                Console.WriteLine($"Jusu skaicius yra: {kvadratas}");
            }
            else if(skaiciusKelejas<=6)
            {
                Console.WriteLine("Per daug nori");
            }



            
        }
    }
}
