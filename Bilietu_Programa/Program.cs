using System;
using System.Collections.Generic;
using System.Linq;

namespace Bilietu_Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> bilietuListas10 = new List<int>();
            List<int> bilietuListas20 = new List<int>();
            List<int> bilietuListas30 = new List<int>();
            List<int> parduotuBilietuListas1 = new List<int>();
            List<int> parduotuBilietuListas2 = new List<int>();
            List<int> parduotuBilietuListas3 = new List<int>();
            List<int> sukurtuBilietuListas10 = new List<int>();
            List<int> sukurtuBilietuListas20 = new List<int>();
            List<int> sukurtuBilietuListas30 = new List<int>();

            while (true)
            {

                Console.WriteLine($"Ačiū, kad naudojatės UAB Bilietėlis paslaugomis. Pirkti bilietus - spauskite {1}. Kurti bilietus - spauskite {2}, ataskaita - {3}, noredami iseiti spauskite {4}");
                int meniuInput = Convert.ToInt32(Console.ReadLine());

                if (meniuInput == 1)
                {

                    Console.WriteLine($"Pasirinkite bilietų tipą: {1} - 10$, {2} - 20$, {3} - 30$ noredami iseiti spauskite {4}");
                    int priceInput = Convert.ToInt32(Console.ReadLine());

                    switch (priceInput)
                    {
                        case 1:
                            int priceOfTicket1 = 10;
                            int amountInput1 = AmountInput();
                            bilietuListas10.Remove(amountInput1);
                            parduotuBilietuListas1.Add(amountInput1);
                            PriceCounter(sukurtuBilietuListas10, amountInput1, priceOfTicket1);
                            break;

                        case 2:
                            int priceOfTicket2 = 20;
                            int amountInput2 = AmountInput();
                            bilietuListas20.Remove(amountInput2);
                            parduotuBilietuListas2.Add(amountInput2);
                            PriceCounter(sukurtuBilietuListas20, amountInput2, priceOfTicket2);
                            break;

                        case 3:
                            int priceOfTicket3 = 30;
                            int amountInput3 = AmountInput();
                            bilietuListas30.Remove(amountInput3);
                            parduotuBilietuListas3.Add(amountInput3);
                            PriceCounter(sukurtuBilietuListas30, amountInput3, priceOfTicket3);
                            break;

                        case 4:
                            CloseApplication();
                            break;
                    }
                    Console.Clear();
                }
                
                if (meniuInput == 2)
                {
                    Console.WriteLine($"Pasirinkite kuriamų bilietų tipą: {1} - 10$, {2} - 20$, {3} - 30$ noredami iseiti spauskite {4}");
                    int createInput = Convert.ToInt32(Console.ReadLine());

                    switch (createInput)
                    {
                        case 1:
                            int bilietuKSkaicius1 = AmountCreations();
                            bilietuListas10.Add(bilietuKSkaicius1);
                            sukurtuBilietuListas10.Add(bilietuKSkaicius1);
                            BilietuKurimas(bilietuListas10);
                            break;
                        case 2:
                            int bilietuKSkaicius2 = AmountCreations();
                            bilietuListas20.Add(bilietuKSkaicius2);
                            sukurtuBilietuListas20.Add(bilietuKSkaicius2);
                            BilietuKurimas(bilietuListas20);
                            break;
                        case 3:
                            int bilietuKSkaicius3 = AmountCreations();
                            bilietuListas30.Add(bilietuKSkaicius3);
                            sukurtuBilietuListas30.Add(bilietuKSkaicius3);
                            BilietuKurimas(bilietuListas30);
                            break;
                        case 4:
                            CloseApplication();
                            break;
                    }
                    Console.Clear();
                }
                

                if (meniuInput == 3)
                {
                    Console.WriteLine($"Sukurtu bilietu kiekis {1}, parduotu bilietu kiekis {2} - nepanaudoti bilietai {3} noredami iseiti spauskite {4}");
                    int ataskaitosInput = Convert.ToInt32(Console.ReadLine());

                    switch (ataskaitosInput)
                    {
                        case 1:

                            SukurtuBAtaskaita(sukurtuBilietuListas10, 10);
                            SukurtuBAtaskaita(sukurtuBilietuListas20, 20);
                            SukurtuBAtaskaita(sukurtuBilietuListas30, 30);
                            break;

                        case 2:
                            ParduotuBAtaskaita(parduotuBilietuListas1, 10);
                            ParduotuBAtaskaita(parduotuBilietuListas2, 20);
                            ParduotuBAtaskaita(parduotuBilietuListas3, 30);
                            break;

                        case 3:
                            BilietuLikutis(bilietuListas10, 10);
                            BilietuLikutis(bilietuListas20, 20);
                            BilietuLikutis(bilietuListas30, 30);
                            break;

                        case 4:
                            CloseApplication();
                            break;

                    }
                    Console.Clear();
                }

                if (meniuInput == 4)
                {
                    CloseApplication();
                }


            }


        }
        public static int AmountInput()
        {
            Console.WriteLine("Iveskite norimą bilietų kiekį");
            int bilietuSkaicius = Convert.ToInt32(Console.ReadLine());
            return bilietuSkaicius;

        }

        public static void PriceCounter(List<int> sukurtuBilietuListas, int AmountInput, int priceOfTicket)
        {
            if (AmountInput > sukurtuBilietuListas.Count)
            {
                for (int i = 0; i < AmountInput; i++)
                {
                    for (int j = 0; j < sukurtuBilietuListas.Count; j++)
                    {
                        if (sukurtuBilietuListas[j] == AmountInput)
                        {
                            int kainaUzBilietus = priceOfTicket * AmountInput;
                            Console.WriteLine($"Kaina už bilietus - {kainaUzBilietus}$");

                        }
                    }
                }
            }
            else
            {   
                Console.WriteLine("Nepakanka bilietu");
            }
                    
                    
                
        }*        public static void SukurtuBAtaskaita(List<int>sukurtuBilietuListas, int bilietuTipas)
        {
            bool isNullOrEmpty = sukurtuBilietuListas?.Any<int>() != true; 
            if (isNullOrEmpty)
            {
                
                Console.Write($"Sukurtu bilietu po {bilietuTipas} nera, ");
            }

            for (int i = 0; i < sukurtuBilietuListas.Count; i++)
            
            {
              
                Console.Write($"Sukurtu bilietu po {bilietuTipas}$ yra:{sukurtuBilietuListas[i]}");
                
            }
            


        }
        public static void ParduotuBAtaskaita(List<int> parduotuBilietuListas, int bilietuTipas)
        {
            bool isNullOrEmpty = parduotuBilietuListas?.Any<int>() != true;
            if (isNullOrEmpty)
            {

                Console.Write($"Parduota bilietu po {bilietuTipas} nera, ");
            }
            for (int i = 0; i < parduotuBilietuListas.Count; i++)
            {
                Console.Write($"Parduota bilietu po {bilietuTipas}$ yra:{parduotuBilietuListas[i]}");
            }
        }
        public static void BilietuLikutis(List<int>bilietuListas, int bilietuTipas)

        {
            bool isNullOrEmpty = bilietuListas?.Any<int>() != true;
            if (isNullOrEmpty)
            {

                Console.Write($"Nepanaudota bilietu po {bilietuTipas} nera, ");
            }
            for (int i = 0; i < bilietuListas.Count; i++)
            {
                Console.Write($"Nepanaudota bilietu po {bilietuTipas}$ yra:{bilietuListas[i]}");
            }
        }
        private static void CloseApplication()
        {
            Console.WriteLine("Aciu, kad naudojotes musu paslaugomis");
            Console.WriteLine("Press any key to close application....");
            Environment.Exit(0);
        }
      
       

    }
}
