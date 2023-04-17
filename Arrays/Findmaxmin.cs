using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Findmaxmin
    {
        public void FindMaxMinFunction()
        {
            int[] numbers = { 51, 4, 6, 98, 12 };

            // get the smallest element
            Console.WriteLine("Small Element is: " + numbers.Min());
            //get the Max element
            Console.WriteLine("Large Element is: " + numbers.Max());
        }
    }
}
