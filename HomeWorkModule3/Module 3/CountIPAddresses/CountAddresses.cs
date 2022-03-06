using System;

namespace CountIPAddresses
{
    public class CountAddresses
    {
        public void CountIP(string[] str)
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

        public int GetIP(string[] arr) //получаем количество адресов в отдельном IP адресе
        {
            int sum = (Convert.ToInt32(arr[0]) * (256 * 3)) + (Convert.ToInt32(arr[1]) * (256 * 2)) + (Convert.ToInt32(arr[2]) * 256) + Convert.ToInt32(arr[3]) + 1;
            return sum;
        }
    }
}
