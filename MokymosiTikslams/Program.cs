using System;

namespace MokymosiTikslams
{
    class Program
    {
        static void Main(string[] args)
        {
            #region String    
            //string sakinys = "zirafu akademija";
            //Console.WriteLine(sakinys.Length); //Paraso kiek elementu yra 
            //Console.WriteLine(sakinys.Contains("akademija")); //Paraso true/false ar yra tai stringe
            //Console.WriteLine(sakinys.IndexOf('f')); //Paraso kelintas indeksas yra, o jeigu jo nera raso -1
            //Console.Clear();
            #endregion
            #region Integer
            //Console.WriteLine(Math.Pow(8, 3)); //pakelia kvadratu
            //Console.Clear();
            #endregion
            #region Bandri estetiniai

            //Console.Write("iveskite savo varda");
            //string vardas = Console.ReadLine();
            //Console.Write("Iveskite savo amziu");
            //string amzius = (Console.ReadLine());
            //Console.WriteLine("Labas" + vardas + "jusu amzius" + amzius); // concat naujas kitamuju iterpimo budas
            //Console.Write(1); //raso viska toje pacioje eiluteje
            //Console.WriteLine(); //raso vis naujoje eiluteje
            //Console.Clear();
            #endregion
            #region Arejai []
            //int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 }; // arejaus sukurimas ir nariu pridejimas. Arejus gali savyje laikyti visu tipu kintamuosius.
            //string[] friends = new string[5]; // sukuriame areju ir parasome kiek elementu jis savyje laikys, bet paciu elementu dar neivardiname
            //friends[0] = "Juste"; // tokiu budu priskiriame arejaus elementams reiksmes
            //Console.WriteLine(luckyNumbers[0]); //parodys 4. Ivedame indeksa to arejaus nario, kuri norime pasiekti.
            //luckyNumbers[1] = 900; //pakeiti arejaus elemento reiksme.
            //Console.WriteLine(luckyNumbers[1]);
            //Console.Clear();
            #endregion
            #region Metodai
            //SayHi("Emilija", 27);
            //Console.WriteLine(PakelkKubu(8));
            //double kubuPakeltasSkaicius = PakelkKubu(7); //metodo rezultatam galima priskirti konkrecius kintamuosius
            //Console.WriteLine(kubuPakeltasSkaicius);
            //Console.Clear();
            #endregion
            #region If statements
            ////if statement turi dvi reiksmes true arba false. 
            //bool isMale =true; //jeigu cia butu false tada apacioje po pirmo ifo nurodyto veiksmo nevykdytu
            //if (isMale) //cia galime rasyti sayga kurios reiksme tik true arba false
            //{
            //    Console.WriteLine("You are male"); //sita parasys bool isMale =true
            //}
            //else
            //{
            //    Console.WriteLine("You are not male"); //sita parays jeigu bool isMale = false
            //}
            //Console.Clear();

            //if su dviem salygom 

            bool isMale = true;
            bool isTall = true;

            if (isMale && isTall) //&& - reiskia and ir reiskia kad abi salygos turi buti true  // if (isMale || isTall) kad butu ture turi buti arba male arba tall
            {
                Console.WriteLine("You are a tall male");
            }
            else if (isMale && !isTall) //sita eilute reiskia jeigu yra vyras bet nera aukstas. ! pries kintamaji reiskia paneigima.
            {
                Console.WriteLine("You are a short male");
            }
            else if (!isMale && isTall) //reiskia tu esi ne vyras, bet aukstas
            {
                Console.WriteLine("You are not male but tall");
            }
            else //sita vykdys tik tada kai kiti 
            {
                Console.WriteLine("You are not male and not tall");
            }
            Console.Clear();
            //if (isMale || isTall) // or. Kad butu true bent vienas (arba abu) is faktu turi buti true;

            Console.WriteLine(GetMax(89,10,100)); //metodas su if kuris grazina didesni skaiciu

            Console.Clear();


            #endregion
            #region Better calculator
            //Console.Write("enter a number");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter Operator");
            //String op = Console.ReadLine();

            //Console.Write("enter a number");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //if (op == "+")
            //{
            //    Console.WriteLine(num1 + num2);
            //}
            //else if (op == "-")
            //{
            //    Console.WriteLine(num1 - num2);
            //}
            //else if (op == "/")
            //{
            //    Console.WriteLine(num1 / num2);
            //}
            //else if (op == "*")
            //{
            //    Console.WriteLine(num1 * num2);
            //}
            //else 
            //{
            //    Console.WriteLine("Invalid operator");
            //}

            //Console.Clear();

            #endregion
            #region Switch Statements
            //Console.WriteLine(GetDay(55));
            #endregion
            #region While loops
            ////kartoja tol kol salyga yra true
            //int index = 1;
            //while (index <= 5)//kartos tol kol indexas netaps 5.
            //{
            //    Console.WriteLine(index);
            //    index++; //po kiekvieno pakartojimo prie indexo bus pridedamas vienetas
            //}


            //do //sitas variantas viena karta prasuks programa nes salyga yra apacioje
            //{
            //    Console.WriteLine(index);
            //    index++; 
            //}
            //while (index <= 5) ;


            //Console.WriteLine("enter yor name");
            //string name = Console.ReadLine();
            //while (name == "")
            //{
            //    Console.WriteLine("enter yor name");
            //     name = Console.ReadLine();
            //} //kartos tol, kol tekstas bus ivestas
            //Console.Clear();

            //Console.Clear();
            #endregion
            #region Guessing game while loop, bool, if.
            //string secretWord = "giraffe";
            //string guess = "";
            //int guessCount = 0;
            //int guessLimit = 3;
            //bool outOfGuesses = false;

            //while (guess != secretWord && !outOfGuesses) //reiskia kad spelios kol neatspes arba kol tures spejimo bandymu
            //{
            //    if (guessCount < guessLimit) //leidziame speti kol spejimu kiekis nevirsyja limito ty 3 bandymu
            //    {
            //        Console.WriteLine("Enter guess");
            //        guess = Console.ReadLine();
            //        guessCount++;  //kiekviena kars prasukant loopa prisides po viena spejima
            //    }
            //    else
            //    {
            //        outOfGuesses = true; 
            //    }

            //}
            //if (outOfGuesses)
            //{
            //    Console.Write("You loose");
            //}
            //else
            //{
            //    Console.Write("You win!");
            //}
            //Console.Clear();
            #endregion
            #region For loops

            //for (int i = 1; i <= 5; i++) // israsys skaicius nuo 1 iki 5 pirmas skaicius nuo ko pradedam, antras iki kiek tesiam, o trecias kas atitiks su i per kiekviena iteracija
            //{
            //    Console.WriteLine(i);
            //}
            //Console.Clear();
            #endregion
            #region Building an exponent method (pakelimas dvieju skaiciu laipsniu)
            //Console.WriteLine(GetPow(3, 2));
            //Console.Clear();
            #endregion
            #region 2d Arrays realiai arejai arejuje
            //int[,] numberGrid = 
            //    {
            //{1,2 },
            //{3,4 },
            //{5,6 },
            //    };
            //Console.WriteLine(numberGrid[1, 1]); //pirmame skaiciuje nurodai kokiame arejuje ieskai, antrame skaiciuje nurodai elemento vieta
            //Console.Clear();
            #endregion
            #region Exeption handling
            //try
            //{
            //    //cia irasome koda
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message); //sita visada rasome taip. Jeigu bus kazkas kas crashina koda - cia pranes.
            //}
            //Console.Clear();
            #endregion
            #region params (metodo dalykas, kai nezinai kiek kintamuju bus metode tai padarai taip kad butu belekiek...aiskinimas 3000)
            //double total = ChechOut(2.99, 18.36, 177.2);
            //Console.WriteLine("total sum"+total);
            #endregion
            #region classes and objects
            //class book - klases pavizdys
            //public string title - class atribute
            // jeigu nori, kad class metodai butu pasiekiami ir matomi naudojant  - captain obvious rasyk public
            #endregion
            #region Random numbers
            //Random random = new Random();
            //int skaicius = random.Next(1, 10); //(duos random nuo 1 iki 9)
            //Console.WriteLine(skaicius);
            //Console.Clear();
            #endregion
            #region Condition (arba kitaip if sutrumpinimas)
            //double temperature = 5;
            //string message;

            //if (temperature >= 15)
            //{
            //    message = "It's warm outside";
            //}
            //else 
            //{
            //    message = "It's cold outside";
            //}
            //Console.WriteLine(message); 
            //// sitas ilgas variantas lygu tam po apacia. Pirmoj dvitaskio pusej rasome true statement, o antroj jeigu false. 

            //message = (temperature>=15)? "It's warm outside" : "It's cold outside";
            //Console.WriteLine(message);

            //// cia dar labiau sutrumpint galima, kad nereiketu kintamojo message :
            //Console.WriteLine((temperature >= 15) ? "It's warm outside" : "It's cold outside");

            #endregion
            #region Constructor
            //    class human
            //    public string name;
            //    public int age;
            //public human(string name, int age)
            //{
            //    this.name = name;
            //    this.age = age;
            //} // and that kids is how i create a constructor 
            #endregion
            #region Inheritance
            //Motinineje klaseje geriausia naudoti bendrus placiai tinkancius kintamuosius(bazinius dalykus, o kitos pecifines klases gali prisidet papildomu savybiu negeneric...)
            //paveledeti galima tik is vienos klases, bet nebutinai is motinines. anima - > dog -> labradoras. (tai galima pavedet labradorui dog (gaus ir dog ir animal savybes)
            public class Cat : Animal // Animal yra motinine klase, : reiskia kad nauja klase cat paveldi pirmines savybes;
        {
            public void SayAu()
            { Console.WriteLine(SayAu); } // cia naujos savybes, priskiriamos tik naujai klasei;
        }

            #endregion


        }
        #region SayHi String
        static void SayHi(string name, int age) //cia surasome kintamuosius, kuriuos reikes ivesti 
        {

            //Console.WriteLine("labas " + name + " jusu amzius " + age); //cia yra veiksmai kuriuos ivesti kintamieji tures atlikti
            
        }


        #endregion
        #region Pakelk kubu 
        static double PakelkKubu(int skaicius)
        {
            double result = Math.Pow(skaicius, 3);
            //Console.WriteLine(result); //galima cia irasyti arba galima be sitos eilutes, o rasyti -> Console.WriteLine(PakelkKubu(6));
            return result; 
        }
        #endregion
        #region GetMax if metodas
        static int GetMax(int num1, int num2, int num3) //sito medoto tikslas issiaiskinti kuris skaicius didesnis ir grazinti ji
        {
            int result;
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }

            return result;
        }
        #endregion
        #region GetDay switch
        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default: /// apsisaugojimas nuo blogu reiksmiu ivedimo
                    dayName = "Invalid Day Number";
                    break;
            }


            return dayName;
        }

        #endregion
        #region GetPow //paima du skaicius ir pakelia viena kito laipsniu
        static int GetPow(int baseNum, int powNum) //sitas metodas paima du skaicius ir pakelia viena kito laipsniu su for loopu
        {
            int result = 1;
            for (int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }
            return result;
        }
        #endregion
        #region params
        static double ChechOut(params double[] prices) //cia kai nezinai kiek tiksliai kintamuju reikes irasyti
        {
            double total = 0;
            foreach (double price in prices)
            {
                total = total + price; //arba galima uzrasyti total += price
            }
            return total;
        }
        #endregion
    }
}

