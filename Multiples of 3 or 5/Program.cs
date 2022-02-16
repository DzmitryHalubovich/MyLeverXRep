using System;

namespace Multiples_of_3_or_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int numb = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum = " + Sum(numb));
        }

        static int Sum(int number)
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
