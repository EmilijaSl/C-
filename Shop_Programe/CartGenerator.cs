using System;
using System.Collections.Generic;
using Shop_Programe.NewFolder;

namespace Shop_Programe
{
    public class CartGenerator
    {

        private Candie_Repository Candie_Repository { get; set; } //uzsisetiname repozitorijas
        private Meat_Repository Meat_Repository { get; set; }
        private Liquid_Repository Liquid_Repository { get; set; }
        private Vegetable_Repository Vegetable_Repository { get; set; }

        public CartGenerator() { } //pridedame beparametri konstruktoriu


        public CartGenerator(Candie_Repository candie_Repository, Meat_Repository meat_Repository, Liquid_Repository liquid_Repository, Vegetable_Repository vegetable_Repository)
        {
            Candie_Repository = candie_Repository;
            Meat_Repository = meat_Repository;
            Liquid_Repository = liquid_Repository;
            Vegetable_Repository = vegetable_Repository;

        }

        public ShopingCart cart = new ShopingCart(); //tam, jog galetume naudoti, turime susikurt nauja prekiu vezimeli


        public void ShopBase() // pagrindine funkcija 
        {

                Console.WriteLine("Good day and Welcome to our shop!");
                Console.WriteLine("Please enter how much money you have");
                decimal buyersWallet = Convert.ToDecimal(Console.ReadLine()); //ivestus pinigus paverciame idsponuojama suma
                Console.Clear();

                bool repeat = true;
                string userInput;

            while (repeat)
            {
                Console.Clear();

                Console.WriteLine("MENIU\n[1]-Check goods \n[2]-Add to cart \n[3]-Check cart\n[4]-Buy\n[5]-Exit");
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        ShowAllGoods();
                        break;

                    case "2":
                        Console.Clear();
                        if (buyersWallet > 0)
                        {
                            Console.WriteLine("Select goods group:");
                            int barCode = ShowAllGoods();
                            AddToCart(barCode);
                        }
                        else
                        {
                            Console.WriteLine("You don't have enough money");
                            Console.ReadLine();
                        }
                        break;
                    case "3":
                        Console.Clear();
                        ShowCart();
                        break;
                    case "4":
                        Console.Clear();
                        buyersWallet = Buy(buyersWallet);
                        break;
                    case "5":
                        Console.WriteLine("Bye");
                        repeat = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Try again");
                        break;

                }
            }


        }
        private int ShowAllGoods()
        {
            Console.WriteLine("[1] - Candies\n [2] - Liquids\n [3] - Meats\n [4] - Vegetables\n [5] - Back to main meniu");
            var userInput = Convert.ToInt32(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    Console.Clear();
                    ShowCandies();
                    Console.ReadLine();
                    return 1;
                case 2:
                    Console.Clear();
                    ShowLiquids();
                    Console.ReadLine();
                    return 2;
                case 3:
                    Console.Clear();
                    ShowMeats();
                    Console.ReadLine();
                    return 3;
                case 4:
                    Console.Clear();
                    ShowVegetables();
                    Console.ReadLine();
                    return 4;
                case 5:
                    return 0;
                default:
                    Console.Clear();
                    Console.WriteLine("Wrong input, try again");
                    Console.ReadLine();
                    return 0;
            }
        }
        private void ShowCandies()
        {
            List<Candie> allCandies = Candie_Repository.Retrive(); //pasigraziname saldainius is saldainiu repo 
            foreach (var good in allCandies) //iteruojame per sarasa, tam kad israsytu goodsus
            {
                Console.WriteLine($"Kind - {good.Name}, price - {good.Price} for kilo, Bar code {good.BarCode}, balance of candies {good.Weight}");
            }
        }
        private void ShowLiquids()
        {
            List<Liquid> allLiquids = Liquid_Repository.Retrive();
            foreach (var good in allLiquids)
            {
                Console.WriteLine($"Kind - {good.Name}, price - {good.Price} for kilo, Bar code {good.BarCode}, balance of liquids {good.Weight}");
            }
        }
        private void ShowMeats()
        {
            List<Meat> allMeats = Meat_Repository.Retrive();
            foreach (var good in allMeats)
            {
                Console.WriteLine($"Kind - {good.Name}, price - {good.Price} for kilo, Bar code {good.BarCode}, balance of meats {good.Weight}");
            }

        }
        private void ShowVegetables()
        {
            List<Vegetable> allVegetables = Vegetable_Repository.Retrive();
            foreach (var good in allVegetables)
            {
                Console.WriteLine($"Kind - {good.Name}, price - {good.Price} for kilo, Bar code {good.BarCode}, balance of vegetables {good.Weight}");
            }
        }
        private void AddToCart(int barCode)
        {
            Console.WriteLine("Enter Bar Code");
            int code = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Quantity");
            double quantity = Convert.ToDouble(Console.ReadLine());
            switch (barCode)
            {
                case 1:
                    cart.AddCandy(barCode, quantity, Candie_Repository);
                    break;
                case 2:
                    cart.AddLiquid(barCode, quantity, Liquid_Repository);
                    break;
                case 3:
                    cart.AddMeat(barCode, quantity, Meat_Repository);
                    break;
                case 4:
                    cart.AddVegetables(barCode, quantity, Vegetable_Repository);
                    break;
                default:
                    break;

            }
           
        }
        private void ShowCart()
        {
            string receipt = GenerateReceipt();
            Console.WriteLine(receipt);
            Console.ReadLine();
        }
        public decimal GetSum()
        {
            decimal sum = 0;
            foreach (var item in cart.Products)
            {
                sum += Convert.ToDecimal(item.Weight) * item.Price;
            }
            return sum;
        }
        private decimal Buy(decimal buyersWallet)
        {
            if (GetSum() < buyersWallet)
            {
                decimal sum = GetSum();
                string eMailAddress = Console.ReadLine();
                string receipt = GenerateReceipt();
                    
                    {
                        cart.ClearCart();
                        buyersWallet -= sum;
                        Console.WriteLine($"Your receipt {GenerateReceipt()}\nYour money balance {buyersWallet}");
                        Console.ReadLine();
                        return buyersWallet;
                    }
                 
            }
            else
            {
                Console.WriteLine("You dont have enough money");
                Console.ReadLine();
                return buyersWallet;
            }

        }
        private string GenerateReceipt()
        {
            string receipt = "";
            foreach (var item in cart.Products)
            {
                receipt += "Good:" + item.Name + ", Quantity" + item.Weight + ", Price" + item.Price + "eur\n";
            }
            receipt += "You have to pay:" + GetSum() + "eur";
            return receipt;
        }
        
    }
       
    }


