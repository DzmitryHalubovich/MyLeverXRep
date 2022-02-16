using System;

namespace ReshenieMassiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int N = int.Parse(Console.ReadLine());

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

            Console.WriteLine();

            for (int i = 0; i < N; ++i)
            {
                for (int j = 0; j < N; ++j)
                {
                    Console.Write("{0,-3}", arr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
