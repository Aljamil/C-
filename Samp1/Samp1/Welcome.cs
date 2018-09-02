using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samp1
{
    class Welcome
    {
        static void Main(string[] args)
        {
            Random randomNumbers = new Random();
            GradeBook al = new GradeBook();
            int a;
           // double b;
            Console.WriteLine("Hello Al!");
         
            a = Convert.ToInt32(Console.ReadLine());
            //b = Convert.ToDouble(Console.ReadLine());

            al.read();

            for(int i = 0; i < 6; i++)
            {
                a = 1 + randomNumbers.Next(55);

                Console.Write("{0} ", a);
            }

            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
