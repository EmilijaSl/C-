using System;
using System.Collections.Generic;
using System.Text;
using InterfacesII.IInterfaces;

namespace InterfacesII.AnimalsClases
{
    public class Dog : IAnimal, IMammal
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public Dog(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public void Eat()
        {
            Console.WriteLine("Dog is eating");
        }
        public void GiveBirth()
        {
            Console.WriteLine("Awww a puppy just born :3");
        }
    }
}
