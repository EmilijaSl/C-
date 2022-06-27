using System;
using System.IO;
using ExceptionHandling;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {


            //Task 1 programa, kuri pagauna klaidas ir ir atspausdina i console. reikiamos klases yra apacioje

            float num1 = 4.5f;

            ToDouble<float>.GetDouble(num1);

            string text1 = "test";

            ToDouble<string>.GetDouble(text1);

            //Task 2 reikejo programai parasant try catch metoda

            int[] arr = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            try
            {
                Console.WriteLine(arr[7]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"Exception caught: {e.Message}");
                throw;
            }
            finally
            {
                Console.WriteLine(arr[7]);
            }

            //Task 3 reikejo pritaikyti try catch metoda
            
            int[] ar = { 19, 0, 75, 52 };

            try
            {
                for (int i = 0; i < ar.Length; i++)
                {
                    Console.WriteLine(ar[i] / ar[i + 1]);
                }
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Exception caught: {e.Message}");
                throw;
            }

            //Task 4

            try
            {
                var data = FileReader.GetFileLines(@"C:\Users\Emilija\Desktop\Trimestrai\Mokiniai.csv.txt");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"Exception caught: {e.Message}");
                throw;
            }
        }


        public class DivideNumbers
        {
            int result = 0;

            public void Division(int num1, int num2)
            {
                try
                {
                    result = num1 / num2;
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine($"Exception caught: {e.Message}");
                    throw;
                }
                finally
                {
                    Console.WriteLine($"Result: {result}");
                }
            }
        }
        public class TempIsZeroException : Exception
        {
            public TempIsZeroException(string message) : base(message) { }
        }
        public class Temperature
        {
            int temperature = 0;

            public void Show()
            {
                if (temperature == 0)
                {
                    throw new TempIsZeroException("Zero temperature found");
                }
                else
                {
                    Console.WriteLine($"Temperature: {temperature}");
                }
            }
        }
        public static class ToDouble<T>
        {
            public static double GetDouble(T input)
            {
                try
                {
                    double result = Convert.ToDouble(input);
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"Exception caught: {e.Message}");
                    throw;
                }
                finally
                {
                    Console.WriteLine("All good");
                }
                return Convert.ToDouble(input);
            }
        }
    }
}
    

    

