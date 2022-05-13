using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETLeverXLab
{
    public class TheClockwiseSpiral
    {
        public int[,] Clockwise(int N)
        {
            int[,] arr = new int[N, N];

            if (N % 2 != 0)
                arr[N / 2, N / 2] = (N * N); //если N нечетное не получается попасть на середину

            int m = 1;

            for (int i = 0; i < (N / 2); ++i)
            {
                for (int j = i; j < (N - i) - 1; ++j, ++m) //j=i что бы делать шаг и не попадать на уже заполненный элемент в точке arr[1,0]
                    arr[i, j] = m;

                for (int j = i; j < N - i; ++j, ++m) //везде -i что бы не налетать на уже созданные элементы
                    arr[j, (N - i) - 1] = m; //надо от N отнять 1 и -i что бы не попадать на уже заполненный

                for (int j = (N - i) - 2; j >= i; --j, ++m)
                    arr[(N - i) - 1, j] = m;

                for (int j = (N - i) - 1; j > 1 + i; --j, ++m)
                    arr[j - 1, i] = m;
            }

            return arr;
        }
        
    }
}
