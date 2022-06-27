using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Advanced_Generics
{
    public class _2PamokosUzduotys
    {
        public class Method<T1, T2> //pirma uzduotis atspausdina ir pakeicia reiksmes
        {
            public T1 MyProperty1 { get; set; }
            public T2 MyProperty2 { get; set; }

            public void PrintT1()
            {
                System.Console.WriteLine(MyProperty1);
            }
            public void PrintT2()
            {
                System.Console.WriteLine(MyProperty2);
            }
            public T1 ChangeT1Value(T1 value)
            {
                MyProperty1 = value;
                return value;
            }
            public T2 ChangeT2Value(T2 value)
            {
                MyProperty2 = value;
                return value;
            }

        }

        public class FourSideGeometricFigure //Antra uzduotis(tesinys yra program C) Esme cia overridinimas
        {
            public string Name { get; set; }
            public double Base { get; set; }
            public double Height { get; set; }

            public double GetArea(int Base, int Height)
            {
                var Area = Base * Height;
                return Area;
            }
            public override string ToString() //be sitos dalies nebutu israsyta paspaudus play
            {
                return $"{Name}, {Base}, {Height}";
            }

        }

        public class Type<T1, T2> //Trecia uzduotis sukurt funkcija, kuri atspausdins input kintamojo duomenu tipa
        {
            public static string GetType(T1 input)
            {
                return input.GetType().ToString();
            }
            public static string GetType(T2 input)
            {
                return input.GetType().ToString();
            }
        }
        public class SportsLeague<S, K, B> //Ketvirta uzduotis, prideti tam tikras komandas i tam tikrus listus 
                                           //where S : SaskiuLyga
                                           //where K : KerlingoLyga
                                           //where B : BadmintonoLyga
        {
            private List<S> SaskiuKomandos { get; set; }
            private List<K> KerlingoKomandos { get; set; }
            private List<B> BadmintonoKomandos { get; set; }

            public void Add(S team)
            {
                SaskiuKomandos.Add(team);

            }
            public void Add(K team)
            {
                KerlingoKomandos.Add(team);

            }
            public void Add(B team)
            {
                BadmintonoKomandos.Add(team);

            }
        }
        public static class CheckIfNotNull<T> //statine klase - reiskia pasiekiama be iskvietimo kitom klasem
        {
            public static void Check(T val) //tikrina ar inputas val ne nulis
            {
                if (val == null)
                {
                    Console.WriteLine("input is a null");
                }
            }
        }

            public class Sarasas1<T>
            {
                readonly List<T> Sar;
                public Sarasas1()
                {
                    Sar = new List<T>();
                }

                public Sarasas1(List<T> list) //priskiriam reiksmes per konstruktoriu
                {
                    Sar = new List<T>();
                    Sar = list;
                }

                public void ShowList() //israso visa sarasa
                {
                    foreach (var item in Sar)
                    {
                        Console.WriteLine(item);
                    }
                }

                public T[] GetArray() //israso sarasa i arreju
                {
                    T[] arrayToGet = new T[Sar.Count];
                    int i = 0;
                    foreach (var item in Sar)
                    {
                        arrayToGet[i++] = item;
                    }
                    return arrayToGet;
                }

                public T GetByValue(T val) //grazina viena atitikmeni is saraso
                {
                    CheckIfNotNull<T>.Check(val);
                    return Sar.Single(x => x.ToString() == val.ToString());

                }
                public T GetByValueOrDefault(T val) //suranda pirma atitikmeni, jeigu neranda grazina defaultine reiksme
                {
                    CheckIfNotNull<T>.Check(val);
                    return Sar.SingleOrDefault(x => x.ToString() == val.ToString());
                }

                public bool CheckIfContains(T val) //patikrina ar yra tokia reiksme sarase ir grazina true arba false
                {
                    CheckIfNotNull<T>.Check(val);
                    return Sar.Any(x => x.ToString() == val.ToString());
                }

            }
        public class Sarasas2<T>
        {
            private List<T> Sar { get; set; } //susikuriam nauja sarasa
            public Sarasas2()  //konstruktas
            {
                Sar = new List<T>();
            }
            public Sarasas2(List<T> list) //
            {
                Sar = new List<T>();
                Sar = list;
            }
            public void ShowList() //israso visa sarasa
            {
                foreach (var item in Sar)
                {
                    Console.WriteLine(item);
                }
            }
            public T[] GetArray() //israso sarasa i areju(masyva)
            {
                T[] arrayToGet = new T[Sar.Count];
                int i = 0;
                foreach (var item in Sar)
                {
                    arrayToGet[i++] = item;
                }
                return arrayToGet;
            }
            public void Add(T val) //prideda nari i sarasa
            {
                CheckIfNotNull<T>.Check(val);
                Sar.Add(val);
                    
            }
            public void AddList(List<T> values) //prideda sarasa i sarasa
            {
                Sar.AddRange(values);

            }
            public void RemoveThing(T val) //istrina nari is saraso
            {
                CheckIfNotNull<T>.Check(val);
                Sar.Remove(val);
            }
            public void RemoveTheThing(T val, int index) //istrina nari poagal indexa
            {
                CheckIfNotNull<T>.Check(val);
                Sar.RemoveAt(index);
            }
            public void RemoveAllThings(T val) //istrina visus atitikmenis is saraso
            {
                CheckIfNotNull<T>.Check(val);
                Sar.RemoveAll(x => x.ToString() == val.ToString());
            }
        }








        
    }
}
