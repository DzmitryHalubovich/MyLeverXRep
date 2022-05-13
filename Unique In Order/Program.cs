using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unique_In_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            //инициализируем и выводим строку 
            string str = "AAAABBBBCCDAABBB";
            Console.WriteLine(str);
            //уникальная строка
            foreach (var item in uniqueInOrder(str))
            {
                Console.Write(item + ", ");
            }

            //инициализируем и выводим массив 
            int[] arr = { 1, 2, 2, 3, 3 };
            Console.Write("\n\n[ ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

            //выводим уникальный массив
            Console.WriteLine("] ");
            foreach (var item in uniqueInOrder(arr))
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();

        }


        static List<dynamic> uniqueInOrder(dynamic str)
        {
            var uniq = new List<dynamic>();

            for (int i = 0; i < str.Length; ++i)
            {
                if (uniq.Count == 0)
                {
                    uniq.Add(str[i]);
                }
                if (uniq.Last() != str[i])
                {
                    uniq.Add(str[i]);
                }
            }

            return uniq;
        }


    }
}
