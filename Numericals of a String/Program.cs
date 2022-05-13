using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Numericals_of_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello, world";
            string str2 = "aacaaaaaabbbaaaac";

            Console.WriteLine(str);
            Console.WriteLine(GetAll(str));
            Console.WriteLine(str2);
            Console.WriteLine(GetAll(str2));
        }

        static string GetAll(string str)
        {
            string answ = "";
            for (int i = 0; i < str.Length; i++)
            {
                int count = 1;
                for (int j = 0; j < i; j++)
                {
                    if (str[i].Equals(str[j]))
                    {
                        count++;
                    }
                }
                answ += count.ToString();
            }
            return answ;
        }
    }
}
