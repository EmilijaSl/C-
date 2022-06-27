using System;
using System.Collections.Generic;
using System.Text;

namespace Linq_Lambda
{
    public class example
    {
        public IEnumerable<string> MyOwnIterator(IEnumerable<string> words)
        {
            foreach (var word in words)
            {
                var list = new List<string>();
                if (word == "orange")
                {
                    yield return word;

                }
            }
            yield return null;
        
        }
    }
}
