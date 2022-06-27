using System;
using System.Collections.Generic;
using System.Text;
using InterfacesII.IInterfaces;

namespace InterfacesII.AnimalsClases
{
    public class Animals : IAnimal
    {
        public string Name { get; set; }
        public string Type { get; set; }
       
        public void Eat()
        {
            Console.WriteLine("Look at that eating animal!");
        }




    }
}
