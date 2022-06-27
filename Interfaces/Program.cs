using System;
using System.Collections.Generic;
using Interfaces.Uzduotys;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //interfaces
            var pizzas = new List<IPizza> { new NewYorkPizza(), new CheesePizza() };
            pizzas.ForEach(pizza => pizza.Prepare());

            //1 uzduotis
            var bmw = new BmwCar(true, "BMW", 50);
            var audi = new AudiCar(false, "Audi", 100);

            bmw.Drive();
            bmw.Refuel(50);

            audi.Drive();
            audi.Refuel(100);
            Console.WriteLine(audi.Model);
            Console.WriteLine(bmw.Model);

            //comparer
            var bmwCars = new List<BmwCar> { new BmwCar(true, "x1", 5), new BmwCar(false, "x20", 10), new BmwCar(true, "x6", 4) };
            var carComparer = new BmwCarComparer();

           bmwCars.Sort(carComparer);

            var audiCars = new List<AudiCar> { new AudiCar(true, "Q3", 10), new AudiCar(false, "Q7", 4), new AudiCar(false, "Q10", 11) };
            var audiComparer = new AudiCarComparer();

            audiCars.Sort(carComparer);
            
        }
    }
}
