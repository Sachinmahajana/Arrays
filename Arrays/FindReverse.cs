using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class FindReverse
    {
      
        public static void FindReverseFunction()
        {
            int[] number = new int[5];
            //declare and and initialize array
            Console.WriteLine("Enter the element in array");
            int i;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(" ", i);
                number[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Display the array element");

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Before reverse:");
                Console.WriteLine("{0}", number[i]);
            }
            Console.WriteLine("After reverse is:");
            for (i = 5 - 1; i >= 0; i--)
            {
                Console.WriteLine("{0}", number[i]);
            }
        }
      
    }
}
