using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_Generics
{
    public static class Validation <T>
    {


        public static void Validate(T item)
        {

            if (item != null)
            {
                Console.WriteLine(item);
            }
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            
          
        }
    }
    public static class ShowValues<T1, T2>
    {

        public static void GiveValues(string T1, int T2)
        {
            Console.WriteLine($"Mano vaardas yra {T1} ir man yra {T2} metai");
        }
    }
}
