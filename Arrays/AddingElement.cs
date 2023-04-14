using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class AddingElement
    {
        public void AddElementFunction()
        {
            Console.WriteLine("How many number of item you want to store");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[num];

            for(int i = 0; i< num; i++)
            {
                Console.WriteLine("Enter the Data");
                int data = Convert.ToInt32(Console.ReadLine());
                numbers[i] = data;
            }
            Console.WriteLine("........Your Data..........");

            foreach(int items in numbers)
            {
                Console.WriteLine(items);
            }
        }
    }
}
