using System;
using Shop_Programe.NewFolder;

namespace Shop_Programe
{
    class Program
    {
        static void Main(string[] args)
        {

            var shopingInProgress = new CartGenerator(new Candie_Repository(), new Meat_Repository(), new Liquid_Repository(), new Vegetable_Repository());
            shopingInProgress.ShopBase();
            

        }
    }
}
