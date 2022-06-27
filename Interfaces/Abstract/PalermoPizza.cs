using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class PalermoPizza : AbstractPizza
    {
        public override int Value { get; set; }
        public override void Prepare()
        {
            System.Console.WriteLine("Preparing <)");
        }
        public override void MakeSauce()
        {
            System.Console.WriteLine("Secret sauce in progress");
        }
    }
}
