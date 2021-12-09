using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class TestIsNumberSimple
    {
        public int number { get; set; }
        public bool expected { get; set; }

        public static void TestIsSimple (int number, bool expected)
        {
            if (Numbers.IsSimple(number) == expected)
            {
                Console.WriteLine("Valid test");
            }
            else
            {
                Console.WriteLine("Invalid test");
            }
        }            
    }
}
