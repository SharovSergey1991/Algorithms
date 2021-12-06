using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Numbers
    {
        static public bool IsSimple(int number)
        {
            int d = 0;
            int i = 2;
            while (i < number)
            {
                if (number % i == 0) d++;
                i++;
            }
            if (d == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
