using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace InterfacesII.AnimalsClases
{
    public class AnimalComparer : Animals, IComparable<Animals>
    {
        
        public int CompareTo(Animals other)
        {
            return other.Name.CompareTo(other.Name);
        }
    }
}
