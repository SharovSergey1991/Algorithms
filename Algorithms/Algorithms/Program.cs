using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            TestIsNumberSimple testCase = new TestIsNumberSimple()
            {
                number = 13,
                expected = true
            };

            TestIsNumberSimple.TestIsSimple(testCase.number, testCase.expected);

            Console.ReadLine();
        }
    }
}
