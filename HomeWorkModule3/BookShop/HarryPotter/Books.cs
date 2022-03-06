using System;
using System.Collections.Generic;

namespace HarryPotter
{
    public class Books
    {
        
        static void Main(string[] args)
        {
            List<int> arrlist = new List<int>();

            Console.WriteLine("Enter the number of copies of the first book:");
            int firstBookCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < firstBookCount; i++)
            {
                arrlist.Add(1);
            }   
            Console.WriteLine("Enter the number of copies of the second book:");
            int secondBookCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < secondBookCount; i++)
            {
                arrlist.Add(2);
            }
            Console.WriteLine("Enter the number of copies of the third book:");
            int thirdBookCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < thirdBookCount; i++)
            {
                arrlist.Add(3);
            }
            Console.WriteLine("Enter the number of copies of the fourth book:");
            int fourthBookCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < fourthBookCount; i++)
            {
                arrlist.Add(4);
            }
            Console.WriteLine("Enter the number of copies of the fifth book:");
            int fifthBookCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < fifthBookCount; i++)
            {
                arrlist.Add(5);
            }

            Console.WriteLine("Total price: " + Math.Round(Purchase(arrlist),2) + " EUR");             
        }

        static public decimal Purchase(List<int> arrlist)
        {
            List<int> arrTemp = new List<int>();
            decimal totalprice = 0;

            while(arrlist.Count>0)
            {
                arrTemp.Add(arrlist[0]);
                for (int i = 0; i < arrlist.Count; i++)
                {
                    if (arrlist[i] > arrTemp[arrTemp.Count - 1])
                    {
                        arrTemp.Add(arrlist[i]);
                    }
                }
                foreach (var item in arrTemp)
                {
                    arrlist.Remove(item);
                }

                totalprice += GetTotalPriceWithDiscount(arrTemp.Count);
                arrTemp.Clear();
            }

            return totalprice;
        }


        static public decimal GetTotalPriceWithDiscount(int count)
        {
            decimal price = 8m;

            switch (count)
            {
                case 1:
                    return price;
                case 2:
                    return (count *price) - (price * count * 5 / 100);
                case 3:
                    return (count * price) - (price * count * 10 / 100);
                case 4:
                    return (count * price) - (price * count * 20 / 100);
                case 5:
                    return (count * price) - (price*count * 25 / 100);
                default:
                    return price;
            }
        }
    }
}
