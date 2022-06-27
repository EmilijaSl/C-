using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Lambda
{
    class Program

    {
        public class Human
        {
            public string Name { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public bool IsHuman { get; set; }
            public List<Animal> Animals { get; set; }

        }
        public class Animal
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        public class HumanEntity
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }

        }
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

        }

        static void Main(string[] args)
        {
            ////pirmas parametras <> yra inputas. Antras yra output
            //Func<string, string> selector = str => str.ToUpper();
            //string[] words = { "orange", "apple", "article", "dog" };

            ////select
            //var upperWords = words.Select(selector);
            //var upperWords2 = words.Select(s => s.ToUpper());

            ////where
            //var wordsWhere = words.Where(s => s.Contains("orange"));

            //var example = new example();
            //var result = example.MyOwnIterator(words);

            ////IEnumerable
            //var wordsList = wordsWhere.ToList();
            //var resultToList = result.ToList();

            ////orderBy / OrderByDescending

            //var humans = new List<Human> { new Human { nameof = "John" }, new Human { nameof = "Tom" } };
            //var orderedHumansAscending = humans.OrderBy(humans => humans.Name); //isdestys nuo a iki z
            //var orderHumansDescending = humans.OrderByDescending(h => h.Name); //nuo z iki a

            ////FirstOrDefault SingleOrDefault = grazina null jeigu nera matcho
            //Human john = humans.FirstOrDefault(h=>h.Name == "John");
            //Human tom = humans.SingleOrDefault(h => h.Name == "Tom");

            ////Firs/Single jeigu nieko neranda grazina exeption
            //Human joe = humans.First(h => h.Name == "Joe");
            //Human joeSingle = humans.First(h => h.Name == "Joe");


            //var humanEntities = new List<HumanEntity> { 
            //    new HumanEntity { ID = 1, Name = "John" },
            //    new HumanEntity { ID = 2, Name = "Tom" },
            //    new HumanEntity { ID = 3, Name = "Joe" }};

            //var humansSelected1 = humanEntities.Select(x => new
            //{
            //    x.Name,
            //    x.LastName,
            //    x.Age
            //});

            //var humansSelected2 = humanEntities.Select(x => new Human
            //{
            //    Name = x.Name,
            //    LastName = x.LastName,
            //    Age = x.Age
            //});

            //var humansSelected3 = humanEntities.Select(x =>
            //{
            //    var t = x.LastName;

            //    bool isHuman = x.LastName + x.Name == "SomeName";

            //    return new Human
            //    {
            //        Name = x.Name,
            //        LastName = x.LastName,
            //        Age = x.Age,
            //        IsHuman = isHuman
            //    };
            //});

            //SELECT MANY

            //var humansWithAnimals = new List<Human>
            //{
            //    new Human
            //    {
            //        Name = "John",
            //        Animals = new List<Animal>
            //        {
            //            new Animal
            //            {
            //                Name = "Cat"
            //            }
            //        }
            //    }
            //};


            //1 uzduotis perkelti skaicius i nauja sarasa paketus kvadratu

            List<double> skaiciuSarasas = new List<double>() { 1, 2, 1, 4, 5, 7, 8, 9, 4, 7, 9, 3, 4, 1 };
            Func<double, double> selector = i => Math.Pow(i, 2);
            var skaiciuSarasas2 = skaiciuSarasas.Select(selector); //select'as pats sukuria lista ir grazina atitinkamai pakoreguota pagal funkcija
            var skaiciuSarasas3 = skaiciuSarasas.Select(s => Math.Pow(s, 2)); //arba (x=> x*x) 
            foreach (var item in skaiciuSarasas3)
            {
                Console.WriteLine(item);
            }

            //2 uzduotis
            List<double> skaiciuSarasas1 = new List<double>() { -1, 2, 1, -4, -5, 7, -8, 9, 4, -7, 9, 3, -4, 1 };
            var sarasasTeigiamu = skaiciuSarasas1.Select(s => s > 0);

            //3 uzduotis 
            List<double> skaiciuSarasas4 = new List<double>() { -1, 2, 1, -4, -5, 7, -8, 9, 4, -7, 9, 3, -4, 1 };
            var sarasasT10 = skaiciuSarasas4.Where(s => s < 10 && s > 0);

            //4 uzduotis
            var skaiciukaiDideja = new List<double>() { 1, 2, 1, 4, 5, 7, 8, 9, 4, 7, 9, 3, 4, 1 };
            var rikiuokDidejancia = skaiciukaiDideja.OrderBy(x => x);

            //5 uzduotis
            var skaiciukaiMazeja = new List<double>() { 1, 2, 1, 4, 5, 7, 8, 9, 4, 7, 9, 3, 4, 1 };
            var rikiuokMazejancia = skaiciukaiMazeja.OrderByDescending(x => x);

            //6 uzduotis
            var didziausiasSkaicius = new List<double>() { 1, 2, 1, 4, 5, 7, 8, 9, 4, 7, 9, 3, 4, 1 };
            var didziausias = didziausiasSkaicius.OrderByDescending(x => x).First();

            //7 uzduotis
            var person = new Person();
            List<Person> persons = new List<Person>();
            persons.Add(new Person { Name = "Jurgis", Age = 41 });
            persons.Add(new Person { Name = "Antanas", Age = 21 });
            persons.Add(new Person { Name = "Aloyzas", Age = 60 });
            persons.Add(new Person { Name = "Martynas", Age = 2 });

            var personsName = persons.Select(x => x.Name); //sudeda tik vardus i nauja sarasa
            var personAge = persons.OrderByDescending(x => x.Age); //Suraso amziu didejancia tvarka i nauja sarasa
            var personNameA = persons.Select(x => x.Name[0] == 'A'); //sukuria sarasa is vardu kurie prasideda A
            var over40 = persons.Where(x => x.Age >= 40).OrderBy(x => x.Name); //paima virs 40 ir suraso pagal vardus

            //8 uzduotis

            var humansWithAnimalsList = new List<Human>
            {
            new Human
            {
            Name = "Petras",
            Animals = new List<Animal>
            {
                new Animal
                { 
                Name = "Aog",
                Age = 6
                },
                new Animal
                { 
                Name = "Cat",
                Age = 1
                }
            }
            },
            new Human
            { 
            Name = "Tomas",
            Animals = new List<Animal>
            { 
            new Animal
            { 
            Name = "Antis",
            Age = 10
            },
            new Animal
            { 
            Name = "Bezdzionka",
            Age = 2
            }
            }
            },
            new Human
            { 
            Name = "Mariuxa",
            Animals = new List<Animal>
            { 
            new Animal
            { 
            Name = "Aango",
            Age = 9
            },
            new Animal
            { 
            Name = "Coco",
            Age = 4
            }
            }
            }
            };
            var animals = humansWithAnimalsList.SelectMany(x => x.Animals).Where(x => x.Name[0] == 'A'); //sarasas visu gyvunu, kurtiu vardai prasideda is raides A
            foreach (var item in animals)
            {
                Console.WriteLine(item.Name);
            }
            var animals5 = humansWithAnimalsList.SelectMany(x => x.Animals).Where(x => x.Age > 5).Where(x => x.Name[0] == 'A');
            foreach (var item in animals5)
            {
                Console.WriteLine($"{item.Name} {item.Age}, ");
            }

            //9 uzduotis
            List<string> list = new List<string> { "asdfgh", "HDGHDIUDH", "jahfLKJLKJ", "JGJFsdhgiueghe" };

            var newList = ReturnUpper(list);
            

            Console.WriteLine(newList);


        }
        public static IEnumerable<string> ReturnUpper(List<string> list) //metodas, kuris grazina tuos stringus, kur visos didziosios raides
        {
            var newtext = list.Where(x => x.All(y => char.IsUpper(y)));
            return newtext;
        }



    }
}
 