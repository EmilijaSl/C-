using System;
using System.Collections.Generic;
using System.Text;
using InterfacesII.IInterfaces;

namespace InterfacesII.AnimalsClases
{
    
    public class Cat : IAnimal, IMammal
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public Cat(string name, string type)
        {
            Name = name;
            Type = type;
        }
        public void Eat()
        {
            Console.WriteLine("Cat is eating");
        }
        public void GiveBirth()
        {
            Console.WriteLine("New cat. Yay.");
        }
    }
}
