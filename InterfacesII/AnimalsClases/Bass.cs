using System;
using System.Collections.Generic;
using System.Text;
using InterfacesII.IInterfaces;

namespace InterfacesII.AnimalsClases
{
    public class Bass : IAnimal, IFish
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public Bass(string name, string type)
        {
            Name = name;
            Type = type;
        }
        public void Eat()
        {
            Console.WriteLine("Look at that eating fish!");
        }
        public void Swim()
        {
            Console.WriteLine("Swim swim swim");
        }
    }
}
