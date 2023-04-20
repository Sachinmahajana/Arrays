using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class ChangeElement
    {
        public void ChangeElementFunction()
        {
            //Create an Array 
            int[] numbers = { 1, 2, 3, 4 };
            Console.WriteLine("Old value at index 0:" + numbers[0]);
            //Change the value at index 0
            numbers[0] = 11;
            //Print the new value
            Console.WriteLine("New value at index 0:" + numbers[0]);
        }
    }
}
