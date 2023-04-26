using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class SumofArray
    {
        public void FindSumofArray()
        {
            int[] numbers = new int[5];
            //declare and initialization of array
            Console.WriteLine("Enter the elements of array");
            int i;
            int Sum = 0;

            for( i = 0; i < 5; i++)
            {
                Console.WriteLine(" ", i);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < 5; i++)
            {
                Sum = Sum + numbers[i];
            }
            Console.WriteLine("Sum of Array element:{0}", Sum);      
        }
    }
}
