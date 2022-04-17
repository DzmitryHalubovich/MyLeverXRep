using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETLeverXLab
{
    class Multiplies3or5
    {
        public int Sum(int number)
        {
            if (number < 0)
                return 0;

            int sum = 0;
            for (int i = 1; i < number; ++i)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            }
            return sum;
        }
    }
}
