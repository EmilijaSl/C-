using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ATM.KlientuInformacija;

namespace ATM.BankomatoReikalai
{
    public class Bankomatas : KlientuDuomenu_Repozitorija
    {
        KlientuDuomenu_Repozitorija KlientuDuomenu_Repozitorija { get; set; }
        Transakciju_Repozitorija Transakciju_Repozitorija { get; set; }
        List<Transakcijos> transakcijos = new List<Transakcijos>();
        public object klientuDuomenu_Repozitorija { get; set; }
        public object transakciju_Repozitorija { get; set; }
        public Bankomatas() { }
        
        public Bankomatas(KlientuDuomenu_Repozitorija klientuDuomenu_Repozitorija, Transakciju_Repozitorija transakciju_Repozitorija)
        {
            KlientuDuomenu_Repozitorija = klientuDuomenu_Repozitorija;
            Transakciju_Repozitorija = transakciju_Repozitorija;
        }

        public void ATM()
        {
            Console.WriteLine("Idekite kortele i bankomata");
            Console.ReadLine();
            var pin = PINIvedimas();
            
            
            if (PINPatikra(pin) == true)
            {
                Console.Clear();
                bool repeat = true;
                string userInput;
                while (repeat)
                {
                    Console.WriteLine("MENIU\n[1] - Pinigu likutis\n[2] - 5 paskutines transakcijos\n[3] - Pinigu isemimas\n[4] - Pinigu inesimas\n[5] - Grazinti kortele");
                    userInput = Console.ReadLine();
                    switch (userInput)
                    {
                        case "1":
                            Console.Clear();
                            PiniguLikutis(pin);
                            break;
                        case "2":
                            Console.Clear();
                            break;
                        case "3":
                            Console.Clear();
                            PiniguGyninimas(pin);
                            break;
                        case "4":
                            Console.Clear();
                            PiniguIdejimas(pin);
                            break;
                        case "5":
                            Console.Clear();
                            repeat = false;
                            break;
                        case "6":
                            Console.Clear();
                            Paskutines(pin);
                            break;


                    }
                }
            }
         
            
        }
        public int PINIvedimas()
        {
            Console.WriteLine("Iveskite savo PIN koda");
            var userInput = Convert.ToInt32(Console.ReadLine());
            return userInput;
        }
        public bool PINPatikra(int userInput)
        {
            {
               

                int guessCount = 0;
                bool outOfguesses = false;

                //var userInput = PINIvedimas();
                    
                    while (RetriveByPIN(userInput) == null && !outOfguesses)
                    {
                        if (guessCount <= 2)
                        {
                            Console.WriteLine("Neteisingas PIN\nBandykite isnaujo");
                            userInput = Convert.ToInt32(Console.ReadLine());
                            guessCount++;
                        }
                        if (guessCount == 2)
                        {
                            outOfguesses = true;
                        }
                    }
                    if (outOfguesses)
                    {
                        Console.WriteLine("Isnaudojote visus bandymus\nKortele uzblokuota");
                        Console.ReadLine();
                        return false;
                    }
                    else
                    return true;
                    
                    
            }
             
            
        }
        public void PiniguLikutis(int pin)
        {
            var piniguLikutis = KlientuDuomenu_Repozitorija.RetrivePIN(pin);
            foreach (var thing in piniguLikutis)
            {
                Console.WriteLine($"Pinigu likutis: {thing.PinigaiSaskaitoje} euriukai");

            }
            
        }
        public void PiniguGyninimas(int pin)
        {
            PiniguLikutis(pin);
            Console.WriteLine($"Iveskite kokia suma norite isgryninti");
            var gryninamaSuma = Convert.ToDecimal(Console.ReadLine());
            var pinigaiSaskaitoje = KlientuDuomenu_Repozitorija.RetriveByPIN(pin);
            if (gryninamaSuma > 1000)
            { 
                Console.WriteLine("Maksimalus dienos limitas 1000 euriuku"); 
            }
            else
            if (gryninamaSuma <= pinigaiSaskaitoje.PinigaiSaskaitoje)
            {
                pinigaiSaskaitoje.PinigaiSaskaitoje -= gryninamaSuma;
                Console.WriteLine($"Issigryninote {gryninamaSuma} euriuku");
                PiniguLikutis(pin);
                transakcijos.Add(new Transakcijos(pin, gryninamaSuma, DateTime.Now));
            }
            if (gryninamaSuma > pinigaiSaskaitoje.PinigaiSaskaitoje)
            {
                Console.WriteLine("Nepakanka euriuku");
            }
                
        }
        public void PiniguIdejimas(int pin)
        {
            PiniguLikutis(pin);
            Console.WriteLine("Iveskite kiek euriuku norite inesti i saskaita");
            var naujiEuriukai = Convert.ToDecimal(Console.ReadLine());
            var pinigaiSaskaitoje = KlientuDuomenu_Repozitorija.RetriveByPIN(pin);
            pinigaiSaskaitoje.PinigaiSaskaitoje += naujiEuriukai;
            Console.WriteLine($"I saskaita pridejote{naujiEuriukai} euriuku");
            PiniguLikutis(pin);
            var info = (pin, naujiEuriukai, DateTime.Now);
            transakcijos.Add(info);





        }
      


    }
}

