using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Advanced_Generics
{
    public class MySelfMadeList<T> //kad nurodytume, jog klase generine pridedam T
    {
        private T[] MyArray { get; set; }
        private int Index = 0;
        private int Size = 10;

        public MySelfMadeList()
        {
            MyArray = new T[Size];
        }

        public void AddItem(T item)
        {
            if (CheckIfNull())
            {
                MyArray = IncreaseArraySize();
            }
            if (item != null)
            {
                MyArray[Index] = item;
                Index++;
            }
            else 
            {
                throw new ArgumentNullException(nameof(item));
            }
        }
        private T[] DecreaseArraySize(T Index1)
        {
            Size += (Size - 1);
            var newArray = new T[Size];

            MyArray.CopyTo(newArray, 0);
            return newArray;

            //MyArray = MyArray.Where((source, Index)Index != Index1).ToArray();
        }
        private bool CheckIfNull()
        {
            return Index == Size; //sita eilute tas pats kas po apacia. Grazins info ar dar yra vietos arejuj
            //if (Index == Size)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
        private T[] IncreaseArraySize()
        {
            Size += (Size / 2); 
            var newArray = new T[Size];

            MyArray.CopyTo(newArray, 0); //sita dalis seno Array duomenis perkopijuoja i naujo Arejaus vidu. 
            return newArray;
        }
        //public T Remove(int i)
        //{ 
        //if(i>= Size || i<0) return default (T);
        //    var imp = MyArray[i];
        //    for (var j = i; j < Size - 1; ++j)
        //    {

        //    }
        //}
    }
}
