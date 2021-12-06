using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Fibonachi
    {
        public static int FibRecurs (int n) // Рекурсивная реализация расчета числа Фибоначи
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }

            return FibRecurs(n - 1) + FibRecurs(n - 2);
        }

        public static int FibCycle (int n) // Реализация расчета числа Фибоначи через цикл
        {
            int fibNum1 = 1;
            int fibNum2 = 1;
            int fibSum = 1;
            for (int i = 1; i <= n; i++)
            {
                if (i == 1)
                {
                    continue;
                }
                else
                {
                    fibSum = fibNum1 + fibNum2;
                    fibNum1 = fibNum2;
                    fibNum2 = fibSum;
                }
            }
            return fibSum;
        }
    }
}
