using System;

namespace NETLeverXLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Multiplies3or5 multiplies = new Multiplies3or5();

            Console.WriteLine("Enter number: ");
            int numb = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum = " + multiplies.Sum(numb));

        }
    }
}
