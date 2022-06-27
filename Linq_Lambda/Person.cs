using System;
using System.Collections.Generic;
using System.Text;

namespace Linq_Lambda
{
    public  class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Animal> Animals { get; set; }

        public Person()
        { 
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
           
        }

        public Person(string name, int age, List<Animal> animals)
        {
            Name = name;
            Age = age;
            Animals = animals;
        }
      
    }
}
