using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class NewYorkPizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing");
        }
    }
}
