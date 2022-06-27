using System;
using System.Collections.Generic;

namespace Delegatai
{
    class Program
    {
        static readonly int GlobalNumber = 10;
        //delegates
        public delegate int NumberChanger(int n);
        private delegate string PersonalInfo(string firstName, string lastName, int age);
        private delegate int TwoNumbers(int a, int b);
        private delegate List<int> ListTask(List<int> listas, int step);
        private delegate string GetType<T>(T element);

        static void Main(string[] args)
        {
            //creating delegates
            var numberChanger1 = new NumberChanger(AddNumber);
            var numberChanger2 = new NumberChanger(SubstractNumber);

            //caling delegates
            Console.WriteLine(numberChanger1(5));
            Console.WriteLine(numberChanger2(6));

           

           //1uzduotis
            var personalInfo = new PersonalInfo(WriteInfo);
            Console.WriteLine(personalInfo("Emilija", "Sliburiene", 27));
            //2 uzduotis
            var twoNumbers = new TwoNumbers(Get2Numbers);
            Console.Write(twoNumbers(7,23));
            //3 uzduotis
            List<int> listas = new List<int>() { 1, 2, 3, 1, 4, 4, 7, 8, 9, 10 };
            var listTask = new ListTask(RetrieveCertain);
            List<int> listas1 = new List<int>();
            listas1 = (listTask(listas, 4));
            foreach (var item in listas1)
            {
                Console.WriteLine(item);
            }
            //4 uzduotis
            
            var typeTask = new GetType<int>(GetTypeMethod);
            Console.WriteLine(typeTask(5)); 





        }
        #region Delegate Methods
        private static int AddNumber(int number)
        {
            return GlobalNumber + number;
        }
        private static int SubstractNumber(int number)
        {
            return GlobalNumber - number;
        }
        private static void PassMethod(NumberChanger method, int number)
        {
            Console.WriteLine(method.Invoke(number));
        }
        private static string WriteInfo(string firstName, string lastName, int age)
        {
            string sentence = ($"Name is {firstName}, last name is {lastName}, and age is {age}");
            return sentence;
        }
        private static int Get2Numbers(int a, int b)
        {
           return a + b;
        }
        private static List<int> RetrieveCertain(List<int> listas, int step)
        {
            List<int> newList = new List<int>();
            for (int i = 0; i < listas.Count; i += step)
            {
                newList.Add(listas[i]); 
            }
            return newList;
        }
        #endregion
        #region Anonymus Delegates
        public static string GetTypeMethod<T>(T element)
        {
            return element.GetType().ToString();
        }
       

        #endregion
    }
}
