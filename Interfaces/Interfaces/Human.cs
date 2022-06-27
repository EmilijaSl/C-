using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Human : inter, ICanEat
    {
        public string GetRunnerName(string name)
        {
            System.Console.WriteLine(name);
            return name;
        }
        public void Run()
        {
            System.Console.WriteLine("Im running");
        }
        public void HumanMethod()
        {
            System.Console.WriteLine("GG");
        }
        public void Eat()
        {
            System.Console.WriteLine("Im eating");
        }
    }
}
