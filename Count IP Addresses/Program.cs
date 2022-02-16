using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_IP_Addresses
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ips_between1 = { "10.0.0.0", "10.0.0.50" };
            string[] ips_between2 = { "10.0.0.0", "10.0.1.0" };
            string[] ips_between3 = { "20.0.0.10", "20.0.1.0" };
            string[] ips_between4 = { "10.1.0.0", "10.0.0.50" };
            string[] ips_between5 = { "10.1.256.0", "10.0.0.50" };

            CountIP(ips_between1);
            CountIP(ips_between2);
            CountIP(ips_between3);
            CountIP(ips_between4);
            CountIP(ips_between5);

            Console.ReadKey();
        }

        static void CountIP(string[] str)
        {
            string[] arr1 = str[0].Split('.');
            string[] arr2 = str[1].Split('.');

            Console.Write($"{arr1[0]}.{arr1[1]}.{arr1[2]}.{arr1[3]} : {arr2[0]}.{arr2[1]}.{arr2[2]}.{arr2[3]}");

            for (int i = 0; i < 4; ++i) //проверка на правильность адреса
            {
                if (Convert.ToInt32(arr1[i]) > 255 || Convert.ToInt32(arr1[i]) < 0)
                {
                    throw new Exception("Oh no! The first address was written incorrectly!\n");
                }
                if (Convert.ToInt32(arr2[i]) > 255 || Convert.ToInt32(arr2[i]) < 0)
                {
                    throw new Exception("Oh no! The second address was written incorrectly!\n");
                }

            }

            if (GetIP(arr2) > GetIP(arr1)) //считаем количество адресов
            {
                Console.WriteLine("\nLet's count our IP dude! Result: " + (GetIP(arr2) - GetIP(arr1)) + "\n");
            }
            else
            {
                Console.WriteLine("\nThat's not cool man! Last address must be greater than the firts one\n");
            }
        }

        static int GetIP(string[] arr) //получаем количество адресов в отдельном IP адресе
        {
            int sum = (Convert.ToInt32(arr[0]) * (256 * 3)) + (Convert.ToInt32(arr[1]) * (256 * 2)) + (Convert.ToInt32(arr[2]) * 256) + Convert.ToInt32(arr[3]) + 1;
            return sum;
        }
    }
}
