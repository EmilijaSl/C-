using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Masyvai
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Masyvu/Areju uzduotys
            /// 6p. 1u.
            //Console.WriteLine("Iveskite skaiciu");
            //int numb1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Iveskite skaiciu");
            //int numb2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Iveskite skaiciu");
            //int numb3 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Iveskite skaiciu");
            //int numb4 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Iveskite skaiciu");
            //int numb5 = Convert.ToInt32(Console.ReadLine());

            //int[] kolekcija = { numb1, numb2, numb3, numb4, numb5 };
            //for (int i = kolekcija.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine($"ciklas {kolekcija[i]}");
            //}




            ////6p.2u.

            //Console.WriteLine("iveskite skaiciu");
            //int numb1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("iveskite skaiciu");
            //int numb2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("iveskite skaiciu");
            //int numb3 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("iveskite skaiciu");
            //int numb4 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("iveskite skaiciu");
            //int numb5 = Convert.ToInt32(Console.ReadLine());

            //int[] kolekcija = { numb1, numb2, numb3, numb4, numb5 };

            //int sum = 0;

            //for (int i = 0; i < kolekcija.Length; i++)
            //{
            //    sum += kolekcija[i];
            //}

            //Console.WriteLine($"Suma yra: {sum}");

            ////6p. 3u.

            //// [] <- arejus {} <- inicializavimas

            //Console.WriteLine("Iveskite skaiciu");
            //int numb1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Iveskite skaiciu");
            //int numb2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Iveskite skaiciu");
            //int numb3 = Convert.ToInt32(Console.ReadLine());

            //int[] kolekcija = { numb1, numb2, numb3 };

            //int num4 = 2;
            //int num5 = 1;

            //Array.Resize(ref kolekcija, 5);

            //kolekcija[3] = num4;
            //kolekcija[4] = num5;

            //foreach (var number in kolekcija)
            //{
            //    Console.WriteLine(number);
            //}




            ////6p. 4u.

            //int[] skaiciai = new int[10];

            //Random random = new Random();

            //for (int i = 0; i < skaiciai.Length; i++)
            //{
            //    skaiciai[i] = random.Next(1, 100);
            //}
            //foreach (var skaicius in skaiciai)
            //{
            //    Console.WriteLine(skaicius);
            //}
            //int max = skaiciai[0];
            //int min = skaiciai[0];

            //for (int i = 0; i < skaiciai.Length; i++)
            //{
            //    if (skaiciai[i] > max)
            //    {
            //        max = skaiciai[i];
            //    }
            //    else if (skaiciai[i] < min)
            //    {
            //        min = skaiciai[i];
            //    }

            //}
            //Console.WriteLine($"\nBiggest number - {max}, \n Lowest number - {min}");



            ////6p. 5u.

            //int[] numArray = new int[10];
            //int[] numArray2 = new int[10];

            //Random rnd = new Random();

            //for (int i = 0; i < numArray.Length; i++)
            //{
            //    numArray[i] = rnd.Next(1, 100);
            //    numArray2[i] = rnd.Next(1, 100);
            //}

            //int[] concatedArray = new int[numArray.Length + numArray2.Length];
            //numArray.CopyTo(concatedArray, 0);
            //numArray2.CopyTo(concatedArray, numArray.Length);

            //foreach (var item in concatedArray)
            //{
            //    Console.WriteLine(item);
            //}
            //for (int i = 0; i < concatedArray.Length; i++)
            //{
            //    for (int j = i + 1; j < concatedArray.Length; j++)
            //    {
            //        if (concatedArray[i] < concatedArray[j])
            //        {
            //            int temp = concatedArray[i];
            //            concatedArray[i] = concatedArray[j];
            //            concatedArray[j] = temp;
            //        }

            //    }

            //}
            //Console.WriteLine("sort");
            //foreach (var item in concatedArray)
            //{
            //    Console.WriteLine(item);
            //}

            ////6p. 6u.

            char[] zodis = new char[6];

            zodis[0] = 'K';
            zodis[1] = 'u';
            zodis[2] = 'r';
            zodis[3] = 's';
            zodis[4] = 'a';
            zodis[5] = 's';

            char[] naujasZodis = new char[zodis.Length - 1];

            int m = 0;
            int n = 0;
            int removeAt = 0;

            while (m < zodis.Length)
            {
                if (m != removeAt)
                {
                    naujasZodis[n] = zodis[m];
                    n++;
                }

                m++;
            }
            Console.WriteLine(zodis);
            #endregion

            #region LISTAI

            //List<string> listas = new List<string>();

            //List<int> intList = new List<int>();

            //List<decimal> decimalList = new List<decimal>();

            //List<bool> boolList = new List<bool>();

            //List<object> objectList = new List<object>(); //sake bloga praktika 



            //listas.Add("jonas");
            //listas.Add("petras");
            //listas.Add("juozas"); //same kaip po apacia

            //List<string> listas2 = new List<string> { "jonas", "petras", "juozas" }; //same kaip virsuje uzrasymas

            //for (int i = 0; i < listas.Count; i++) //count yra listo length(length yra arejaus)
            //{
            //    Console.WriteLine(listas[i]);
            //}

            //foreach (var item in listas)
            //{
            //    Console.WriteLine(item);
            //}

            //listas.RemoveAt(5);

            //listas.Insert(5, "Onute"); //ideti kintamaji
            //listas.AddRange(listas2); //ideti lista i lista
            //bool isContains = listas.Contains("Petras"); 
            //int indexas = listas.LastIndexOf("Petras");

            ////7p. 1u. uzpildyti sarasa random ir isvesti lyginius skaicius


            //List<int> skList = new List<int>();
            //Random random = new Random();

            //for (int i = 0; i < 100; i++)
            //{
            //    skList.Add(random.Next(1, 100));
            //    if (skList[i] % 2 == 0)
            //    {
            //        Console.WriteLine(skList[i]);
            //    }
            //}



            ////7p. 2u. sujungti du sarasus ir surusiuoti

            //list<string> studentulistas = new list<string> { "jurgis", "antanas", "aloyzas", "martynas" };

            //list<string> studentulistas2 = new list<string> { "ona", "aldona" };

            //studentulistas.addrange(studentulistas2);

            //studentulistas.sort();

            //for (int i = 0; i < studentulistas.count; i++)
            //{

            //    console.writeline(studentulistas[i]);
            //}

            ////7p. 3u. manipuliuoti sarasu - prideti pakeisti istrinti

            //List<string> varduListas = new List<string> { "Jurgis", "Antanas", "Aloyzas", "Martynas", "Virgutis" };
            //varduListas.Insert(5, "Napoleonas");
            //varduListas.Insert(6, "Asterisas");
            //varduListas.RemoveAt(2);
            //varduListas.RemoveAt(4);
            //varduListas.Insert(5, "Kleopatra");

            //for (int i = 0; i < varduListas.Count; i++)
            //{
            //    Console.WriteLine(varduListas[i]);
            //}

            ////7p. 4u. meniu tipo programa 


            //List<int> skList = new List<int>();

            //skList.Add(8);
            //skList.Add(10);
            //skList.Add(10);
            //skList.Add(9);
            //skList.Add(8);
            //skList.Add(10);
            //Console.WriteLine($"Iveskite simboli: {0} - papildyti, {1} - istrinti, {2} - iterpti, {3} - vidurkis, {4} - iseiti ");
            //int userSelection = Convert.ToInt32(Console.ReadLine());


            //while (true)
            //    switch (userSelection)
            //    {
            //        case 0:
            //            Console.WriteLine("Iveskite pazimy");
            //            int userInput = Convert.ToInt32(Console.ReadLine());
            //            skList.Add(userInput);
            //            break;

            //        case 1:
            //            Console.WriteLine("kuri pazimi norite istrinti?");
            //            for (int i = 0; i < skList.Count; i++)
            //            {
            //                Console.WriteLine($"indeksas:{i} - {skList[i]}");
            //            }
            //            int userInput1 = Convert.ToInt32(Console.ReadLine());
            //            skList.RemoveAt(userInput1);
            //            break;

            //case 2:
            //    Console.WriteLine("Iveskite pazimy");
            //    int userInput2 = Convert.ToInt32(Console.ReadLine());
            //    for (int i = 0; i < skList.Count; i++)
            //    {
            //        Console.WriteLine($"indeksas:{i} - {skList[i]}");
            //    }
            //    Console.WriteLine("iveskite indeksa");
            //    int userInput3 = Convert.ToInt32(Console.ReadLine());
            //    skList.Insert(userInput3, userInput2);
            //    break;

            //case 3:


            //    double average = skList.Average();
            //    Console.WriteLine($"vidurkis - {average}");

            //    break;

            //case 4: 
            //    break;

            //7p. 5u.

            //List<int> list1 = new List<int> { 1, 2, 4, 8, 16 };
            //List<int> list2 = new List<int> { 2, 4, 8 };
            //Console.Write(list1.Contains(2));

            ////7p. 5u. sukurti du sarasus uzpildyti duomenimis(uzpildai pats) ir patikrinti ar antro saraso skaiciai sutampa su pirmo

            //List<int> list1 = new List<int> ();
            //List<int> list2 = new List<int> ();
            //for (int i = 0; i < 5; i++)
            //{
            //    bool isValid;
            //    do
            //    {
            //        Console.WriteLine($"iveskite {i + 1}-aji skaiciu");
            //        string input = Console.ReadLine();
            //        isValid = int.TryParse(input, out int num);
            //        list1.Add(num);
            //    } while (!isValid);
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    bool isValid;
            //    do
            //    {
            //        Console.WriteLine($"iveskite {i + 1}-aji skaiciu");
            //        string input = Console.ReadLine();
            //        isValid = int.TryParse(input, out int num);
            //        list2.Add(num);
            //    } while (!isValid);
            //}
            //Console.WriteLine("\nPirmasis sarasas:");
            //foreach (var item in list1)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\nAntrasis sarasas:");
            //foreach(var item in list2)
            //{
            //    Console.WriteLine(item);
            //}
            //int NumOfContained = 0;
            //for (int i = 0; i < list1.Count; i++)
            //{
            //    for (int j = 0; j < list2.Count; j++)
            //    {
            //        if (list1[i]==list2[j])
            //        {
            //            NumOfContained++;
            //        }

            //    }

            //}
            //if (NumOfContained == list2.Count)
            //{
            //    Console.WriteLine("Antras sarasas yra dalis pirmo saraso");
            //}
            //else
            //{
            //    Console.WriteLine("Antras sarasas nera dalis pirmo");
            //}

            ////7p. 7u. sukurti sarasa ir pamatuoti kiek uztruko rusiavimas
            //List<int> dxjSkaiciu = new List<int>();
            //Random random = new Random();
            //for (int i = 0; i <= 100000; i++)
            //{
            //    dxjSkaiciu.Add(random.Next(1, 10));
                
            //}
            //var watch = System.Diagnostics.Stopwatch.StartNew();
            //dxjSkaiciu.Sort();
            //watch.Stop();
            //var elapsedms = watch.ElapsedMilliseconds;
            //Console.WriteLine($"laikas yra - {elapsedms}");


                
                

                        ////7p. 8u. nuskaityti faila is kompo ir ji surusiuoti

                        //List<string> countries = new List<string>();
                        //using (StreamReader countriesFile = new StreamReader("countries.txt")) //egzistuojanti faila kompiuteryje naudojame visual studio
                        //{
                        //    string readLine;
                        //    while ((readLine = countriesFile.ReadLine()) != null)
                        //    {
                        //        countries.Add(readLine);
                        //    }
                        //}
                        //countries.Sort();

                        //foreach (string country in countries)
                        //{
                        //    Console.WriteLine(country);
                        //}

                        //using (StreamWriter sw = File.CreateText)



                        //string vardas = "C#Kursas";
                        //for (int i = 0; i < vardas.Length; i++)
                        //{
                        //    //char current = vardas[i];
                        //    Console.WriteLine(i);
                        //}





















                }



            #endregion



        }
    }

