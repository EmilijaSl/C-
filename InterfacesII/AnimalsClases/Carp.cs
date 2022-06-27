using System;
using System.Collections.Generic;
using System.Text;
using InterfacesII.IInterfaces;

namespace InterfacesII.AnimalsClases
{
    public class Carp : IAnimal, IFish
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public Carp(string name, string type)
        {
            Name = name;
            Type = type;
        }
        public void Eat()
        {
            Console.WriteLine("Niam niam niam");
        }
        public void Swim()
        {
            Console.WriteLine("Swim swam swum hehe");
        }
    }
}
