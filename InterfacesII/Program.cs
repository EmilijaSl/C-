using System;
using System.Collections.Generic;
using InterfacesII.AnimalsClases;
using InterfacesII.BBB;
using InterfacesII.Figures;
using InterfacesII.IInterfaces;

namespace InterfacesII
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<IAnimal> { new Cat("Murka", "kate"), new Dog("Brisius", "suo"), new Bass("Igoris", "upetakis"), new Carp("Karosijus", "karpis") };
            animals.ForEach(animal => animal.Eat());

            var mammals = new List<IMammal> { new Cat("Kisa", "kate"), new Dog("Amsius", "suo") };
            mammals.ForEach(mammal => mammal.GiveBirth());

            var fishes = new List<IFish> { new Bass("Zuvijus", "upetakis"), new Carp("Karpacijus", "karpis") };
            fishes.ForEach(fish => fish.Swim());

            var compareAnimals = new List<IAnimal> { new Cat("Murka", "kate"), new Dog("Brisius", "suo"), new Bass("Igoris", "upetakis"), new Carp("Karosijus", "karpis") };
            var animalComparer = new AnimalComparer();
            //compareAnimals.Sort();
            Staciakampis staciakampis = new Staciakampis(10.02, 62);
            Trikampis trikampis = new Trikampis(100, 12.3);
            Kvadratas kvadratas = new Kvadratas(18, 99.2);

            List<IPolygon> figuricos = new List<IPolygon> { staciakampis, trikampis, kvadratas };
            Console.WriteLine("Nerusiuotas sarasas:");
            foreach (var item in figuricos)
            {
                Console.WriteLine(item.GetArea());
            }

            var figuricuKompareris = new FiguruKompareris();
            figuricos.Sort(figuricuKompareris);
            Console.WriteLine("Rusiuotas sarasas:");
            foreach (var item in figuricos)
            {
                Console.WriteLine(item.GetArea());
            }


            
        }
    }
}
