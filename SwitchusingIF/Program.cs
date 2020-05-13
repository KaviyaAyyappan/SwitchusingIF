using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchusingIF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the result:");
            int result = int.Parse(Console.ReadLine());
            // if else statement
            if (result >= 9)
            {
                Console.WriteLine("Excellent");
            }
            else if (result >= 7 && result <= 8)
            {
                Console.WriteLine("Notable");
            }
            else if (result == 6)
            {
                Console.WriteLine("Good");
            }
            else if (result == 5)
            {
                Console.WriteLine("pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            Console.Read();
        }
    }
}
