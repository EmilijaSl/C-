using System;
using System.Collections.Generic;
using static Advanced_Generics._2PamokosUzduotys;

namespace Advanced_Generics
{
    class Program
    {
        public class Human
        { 
        public string Name { get; set; }
        public string LastName { get; set; }

            public override string ToString() //be sitos dalies nebutu israsyta paspaudus play
            {
                return $"{Name} {LastName}";
            }
        }

        public class Generator<T>  //2pamokos antra uzduotis
        {
            public void Show(T Item)
            {
                Console.WriteLine(Item);
                
            }

        }
        public struct HumanStruct
        { 
        public string Name { get; set; }
            public string LastName { get; set; }
        }
        static void Main(string[] args)
        {
            ShowItem<string>("name");
            ShowItem<int>(5);
            ShowItem<Human>(new Human { Name = "John", LastName = "Doe" });

            GetItemType<Human>(new Human { Name = "John", LastName = "Doe" }); //gettype isveda i console kintamojo tipa (ins string ar klase)
            GetItemType<string>("stringas");
            GetItemType<int>(10);

            var selfMadeList = new MySelfMadeList<int>();
            for (int i = 0; i < 1000; i++)
            {
                selfMadeList.AddItem(i);
            }

            Validation<string>.Validate("2");

            ShowValues<string, int >.GiveValues("Emilija", 27);

            var orderRepo = new OrderRepository();
            var baseRepo = new BaseRepository<Order>(new List<Order> { new Order { Id = 1, Name = "Test" } });
            var result = baseRepo.Get();

            var structRepo = new BaseRepositoryStruct<HumanStruct>();

        }
        public static void ShowItem<T>(T item)
        {
            Console.WriteLine("Item:{0}", item);
        }
        public static void GetItemType<T>(T item)
        {
            Console.WriteLine(item.GetType().Name);
        }
        //Generic constraints
        
        


    }
}
