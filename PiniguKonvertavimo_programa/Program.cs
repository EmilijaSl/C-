using System;

namespace PiniguKonvertavimo_programa
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
               

                decimal userAmount = GautiTSuma();
                

                Console.WriteLine($"I ka noretumete kovertuoti {1} USD, {2} PLN, {3} BYR. Jeigu persigalvojote ir norite iseiti spauskite {4}");
                int userCurency = Convert.ToInt32(Console.ReadLine());

                

                switch (userCurency)
                {
                    case 1:
                        KonvertuokUSD(userAmount);
                        break;
                    case 2:
                        KonvertuokPLN(userAmount);
                        break;
                    case 3:
                        KonvertuokBYR(userAmount);
                        break;
                    case 4:
                        CloseApplication();
                        break;


                }
            }
        }
      
        private static decimal GautiTSuma()
        {
            bool isCorrectNumber = false;
            decimal argumentValue = 0;

            while (!isCorrectNumber)
            {
                Console.WriteLine("Kokia suma noretumete konvertuoti? Jeigu norite iseiti spauskite X");
                string userAmount = (Console.ReadLine());
                CheckCloseApplication(userAmount);
                if (decimal.TryParse(userAmount, out argumentValue))
                {
                    isCorrectNumber = true;
                }
                else
                {
                    Console.WriteLine("Vaflis ne tortas, raide ne skaicius. Skaiciu pvz 1,2,3...");
                }
            }
            return argumentValue;
        }
        public static void KonvertuokUSD(decimal userInput)
        {

            decimal jusuSuma = userInput * 1.11m;
            Console.WriteLine($"Konvertuota suma i USD {jusuSuma} pinigu");
        }
        public static void KonvertuokPLN(decimal userInput)
        {

            decimal jusuSuma = userInput * 4.66m;
            Console.WriteLine($"Konvertuota suma i PLN {jusuSuma} pinigu");
        }
        public static void KonvertuokBYR(decimal userInput)
        {

            decimal jusuSuma = userInput * 3.62m;
            Console.WriteLine($"Konvertuota suma i BYR {jusuSuma} pinigu");
        }
        private static void CloseApplication()
        {
            Console.WriteLine("Aciu, kad naudojotes musu paslaugomis, lauksime sugriztant");
            Console.WriteLine("Press any key to close application....");
            Environment.Exit(0);
        }
        private static void CheckCloseApplication(string input)
        {
            if (input.Equals("x", StringComparison.OrdinalIgnoreCase))
            {
                CloseApplication();
            }
        }
    }
}
