using System;
using System.Collections.Generic;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "Hello, this is my first extension method";
            //var result = str.PrintString().PrintString2();

            //int num = 5;
            //num.PrintIntValue();

            //int sum = num.AddAndPrintValue(6);

            //Task 1 metodas sveikiems skaiciams kur bool grazina atsakyma ar skaicius teigiamas

            //int num1 = 10;
            //int num2 = -10;
            //Console.WriteLine(num1.IsPossitive());
            //Console.WriteLine(num2.IsPossitive());

            //Task 2 grazina ar skaicius lyginis ar ne 

            //int num3 = 5;
            //int num4 = 2;
            //Console.WriteLine(num3.IsEven());
            //Console.WriteLine(num4.IsEven());

            //Task 3 grazina ar per parametra paduotas skaicius didesnis

            //int num5 = 10;
            //Console.WriteLine(num5.IsBigger(12));
            //Console.WriteLine(num5.IsBigger(8));

            //Task 4 grazina bool ar sakinyje yra tarpu

            //string str1 = "test";
            //string str2 = "te st";
            //Console.WriteLine(str1.ContainsWhiteSpace());
            //Console.WriteLine(str2.ContainsWhiteSpace());

            //Task 5 grazina rezultata kaip el pasto adresa

            //string fullName1 = "Linas";
            //string fullName2 = "Algis";
            //string yearOfBirth1 = "1990";
            //string yearOfBirth2 = "1985";
            //string domain1 = "hotmail.com";
            //string domain2 = "gmail.com";

            //Console.WriteLine(MyExtension.GetEMailAddress(fullName1, yearOfBirth1, domain1));
            //Console.WriteLine(MyExtension.GetEMailAddress(fullName2, yearOfBirth2, domain2));

            //Task 6 paima T kaip parametra ir grazina, jeigu randa atitikmeni sarase

            //List<int> list1 = new List<int>() { 1, 2, 3 };
            //Console.WriteLine(list1.FindAndReturnIfEqual<int>(2));
            //Console.WriteLine(list1.FindAndReturnIfEqual<int>(5));

            //List<string> list2 = new List<string>() { "aaa", "bbb", "ccc" };
            //Console.WriteLine(list2.FindAndReturnIfEqual<string>("aaa"));
            //Console.WriteLine(list2.FindAndReturnIfEqual<string>("X"));

            //Task 7 grazina nauja sarasa is kas antro elemento

            //List<int> list3 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            //List<int> list4 = list3.EveryOtherItem<int>();
            //foreach (var item in list4)
            //{
            //    Console.WriteLine(item);
            //}

            //List<char> list5 = new List<char>() { 'a', 'b', 'a', 'b', 'a', 'b', 'a', 'b', };
            //List<char> list6 = list5.EveryOtherItem<char>();
            //foreach (var item in list6)
            //{
            //    Console.WriteLine(item);
            //}

            //Task 8 
            //Negalime sukurti extension metodu statinei klasei, nes jie priskiriami instance'ui.

        }
        //This keyword
        public class Human
        {
            public string Name { get; set; }
            public string LastName { get; set; }
            public Human() { }
            public Human(string name, string lastName)
            {
                this.Name = name;
                this.LastName = lastName;
            }
        }

    }
    //Extension method class
    public static class MyExtension
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
        public static void PrintIntValue(this int num)
        {
            Console.WriteLine(num);
        }
        public static string PrintString(this string str)
        {
            Console.WriteLine(str);
            return str;
        }
        public static string PrintString2(this string str)
        {
            Console.WriteLine(str);
            return str;
        }
        public static int AddAndPrintValue(this int num, int num2)
        {
            int sum = num + num2;
            Console.WriteLine(sum);
            return sum;
        }
        public static bool IsPossitive(this int num) 
        {
            return num > 0;
        }
        public static bool IsEven(this int num)
        {
            return (num % 2) == 0;
        }
        public static bool IsBigger(this int num1, int num2)
        {
            return num1 < num2;
        }
        public static bool ContainsWhiteSpace(this string str)
        {
            return str.Contains(" ");
        }
        public static string GetEMailAddress(string name, string yearOfBirth, string domain)
        {
            return $"{name}{yearOfBirth}@{domain}";
        }
        public static T FindAndReturnIfEqual<T>(this List<T> list, T item)
        {
            if (list.Contains(item))
            {
                return item;
            }

            return default;
        }
        public static List<T> EveryOtherItem<T>(this List<T> list)
        {
            List<T> newList = new List<T>();

            for (int i = 0; i < list.Count; i += 2)
            {
                newList.Add(list[i]);
            }

            return newList;
        }
        //public static void Test(this System.IO.File file) { }
    }
}
    


