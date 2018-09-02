using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSamp
{
    public class Generic1
    {
      
            public static void Main(string[] args)
            {
              Console.WriteLine("Maximum of {0}, {1}, and {2} is {3}.\n", 3, 4, 5, Maximum(3, 4, 5));
              Console.WriteLine("Maximum of {0}, {1} and {2} is {3}\n", 6.6, 8.8, 7.7, Maximum(6.6, 8.8, 7.7));
              Console.WriteLine("Maximum of {0}, {1} and {2} is {3}\n", "pear", "apple", "orange", Maximum("pear", "apple", "orange"));

              Console.ReadKey();
            }

            public static A Maximum <A> (A a, A b, A c)
            where A: IComparable<A>
            {
                A max = a;

                if (b.CompareTo(max) > 0)
                    max = b;
                if (c.CompareTo(max) > 0)
                    max = c;

                return max;
            }
        
    }
}
