using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public abstract class AbstractPizza
    {
        public abstract int Value { get; set; }
        public abstract void Prepare();
        public virtual void MakeSauce() //zodis virtual suteikia klasem paveldinciom metoda ji modifikuoti
        {
            System.Console.WriteLine("Making some kind of sauce");
        }
    }
}
