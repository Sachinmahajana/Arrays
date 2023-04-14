using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class BasicArray
    {
        public void Element()
        {
            string[] person = new string[5];
            person[0] = "Rahul";
            person[1] = "Ajay";
            person[2] = "Pramod";
            person[3] = "Shantanu";
            person[4] = "Anish";

            for (int i = 0; i < person.Length; i++)
            {
                Console.WriteLine(person[i]);
            }
        }
    }
}

