using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class CheesePizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing");
        }
    }
}
