using System;
using System.Linq;

namespace metodai2 //suskleisti metodus spaudcziam controm M O, atskleisti control M L 
{
    class Program
    {
        private static readonly string[] _validOperators = { "+", "-", "*", "/" };
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    double firstNum = GetNumberFromConsole();
                    double secondNum = GetNumberFromConsole();
                    string operatorValue = GetOperatorFromConsole();

                    double result = PerformCalculation(firstNum, secondNum, operatorValue);
                    Console.WriteLine($"Result:{result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error {ex.Message}");
                }
             
            }    
           
        }
        public static double PerformCalculation(double firstNum, double secondNum, string opperation)
        {
            double result = 0;
            switch (opperation)
            {
                case "+":
                    result = Add(firstNum, secondNum);
                    break;
                case "-":
                    result = Minus(firstNum, secondNum);
                    break;
                case "*":
                    result = Multiply(firstNum, secondNum);
                    break;
                case "/":
                    result = Divide(firstNum, secondNum);
                    break;
                default:
                    result = 0;
                    break;
            }
            return result;
        }
        private static double GetNumberFromConsole()
        {
            bool isCorrectNumber = false;
            double argumentValue = 0;

            while (!isCorrectNumber)
            {
                Console.WriteLine("Enter a number or Q to exit");
                string userInputValue = Console.ReadLine();

                ChechApplicationExit(userInputValue);

                if (double.TryParse(userInputValue, out argumentValue))
                {
                    isCorrectNumber = true;
                }
                else
                {
                    Console.WriteLine("please enter valid number");
                }
                
            }
            return argumentValue;


        }

        private static string GetOperatorFromConsole()
        {
            bool isCorrectOperator = false;
            string operatorValue = string.Empty;

            while (!isCorrectOperator)
            {
                Console.WriteLine($"Enter an operator or q to exit. Allowed operators: {string.Join(",", _validOperators)}");
                string userInputValue = Console.ReadLine();

                ChechApplicationExit(userInputValue);

                if (isOperatorValid(userInputValue))
                {
                    operatorValue = userInputValue;
                    isCorrectOperator = true;
                }
                else
                {
                    Console.WriteLine("Please enter valid operator");
                }


                ChechApplicationExit(userInputValue);


            }
            return operatorValue;
        }
        private static double Add(double firstNum, double secondNum)
        {
            //double sum = firstNum + secondNum;
            //return sum;
            return firstNum + secondNum;
        }
        private static double Minus(double firstNum, double secondNum)
        {
            return firstNum - secondNum;
        }
        private static double Multiply(double firstNum, double secondNum)
        {
            return firstNum * secondNum;
        }
        private static double Divide(double firstNum, double secondNum)
        {
            if (secondNum == 0)
            {
                throw new DivideByZeroException("cant divide from zero");
            }
            return firstNum / secondNum;
        }
        private static bool isOperatorValid(string userInputValue)
        {
            //bool isOperatorValid = false;
            //isOperatorValid = _validOperators.Contains(userInputValue);
            //return isOperatorValid; //vr 1

            return _validOperators.Contains(userInputValue);  //vr2
        }
        private static void CloseApplication()
        {
            Console.WriteLine("Goodbye, thank you for using calculator");
            Console.WriteLine("Press any key to close application");
            Environment.Exit(0);

        }

        private static void ChechApplicationExit(string input)
        {
            if (input.Equals("q", StringComparison.OrdinalIgnoreCase))
            {
                CloseApplication();
            }
        }
    }
}
