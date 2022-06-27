using System;

namespace _10_Tema_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            i = 50;

            int x = i;
            x = 99;
            //i gaunasi 99
            Customer i1 = new Customer();
            i1.FirstName = "jonas";
            Customer x1 = i1;
            x1.FirstName = "Petras";
        }
    }
}
