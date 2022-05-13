using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    public class Book
    {
        protected string Name;

        static public List<int> countOfBooks = new List<int>();

        public Book(double price)
        {
            Price = price;
        }

        static public double Price { get; set; }

        public List<int> ReturnList()
        {
            return countOfBooks;
        }

        public void PrintPrice()
        {
            Console.WriteLine("Цена за одну книгу без скидки: " + Price);
        }

        public double Purchase()
        {
            List<int> arrTemp = new List<int>();
            double totalprice = 0;
            
            while (countOfBooks.Count > 0)
            {
                arrTemp.Add(countOfBooks[0]);
                for (int i = 0; i < countOfBooks.Count; i++)
                {
                    if (countOfBooks[i] > arrTemp[arrTemp.Count-1])
                    {
                        arrTemp.Add(countOfBooks[i]);
                    }
                }
                foreach (var item in arrTemp)
                {
                    countOfBooks.Remove(item);
                }

                totalprice += GetTotalPriceWithDiscount(arrTemp.Count);
                arrTemp.Clear();
            }

            return totalprice;
        }

        static public double GetTotalPriceWithDiscount(int countDifferentBooks)
        {
            double price = Price;

            switch (countDifferentBooks)
            {
                case 1:
                    return price;
                case 2:
                    return (countDifferentBooks * price) - (price * countDifferentBooks * 5 / 100);
                case 3:
                    return (countDifferentBooks * price) - (price * countDifferentBooks * 10 / 100);
                case 4:
                    return (countDifferentBooks * price) - (price * countDifferentBooks * 20 / 100);
                case 5:
                    return (countDifferentBooks * price) - (price * countDifferentBooks * 25 / 100);
                default:
                    return price;
            }
        }

    }

    class BookFirst : Book
    {
        
        public BookFirst(double Price) : base(Price) 
        {
            Name = "Гарри поттер и философский камень";
            countOfBooks.Add(1);
        }
    }

    class BookSecond : Book
    {
        public BookSecond(double Price) : base(Price)
        {
            Name = "Гарри поттер и тайная комната";
            countOfBooks.Add(2);
        }
    }

    class BookThird : Book
    {
        public BookThird(double Price) : base(Price)
        {
            Name = "Гарри поттер и узник азкабана";
            countOfBooks.Add(3);
        }
    }

    class BookFourth : Book
    {
        public BookFourth(double Price) : base(Price)
        {
            Name = "Гарри поттер и кубок огня";
            countOfBooks.Add(4);
        }
    }
    class BookFifth : Book
    {
        public BookFifth(double Price) : base(Price)
        {
            Name = "Гарри поттер и орден феникса";
            countOfBooks.Add(5);
        }
    }

    abstract class Basket
    {
        public abstract Book AddToBasket();
    }

    class AddFirstBookToBasket : Basket
    {
        double price = Book.Price;
        public override Book AddToBasket()
        {
            return new BookFirst(price);
        }
    }

    class AddSecondBookToBasket : Basket
    {
        double price = Book.Price;
        public override Book AddToBasket()
        {
            return new BookSecond(price);
        }
    }

    class AddThirdBookToBasket : Basket
    {
        double price = Book.Price;
        public override Book AddToBasket()
        {
            return new BookThird(price);
        }
    }

    class AddFourthBookToBasket : Basket
    {
        double price = Book.Price;
        public override Book AddToBasket()
        {
            return new BookFourth(price);
        }
    }

    class AddFifthBookToBasket : Basket
    {
        double price = Book.Price;
        public override Book AddToBasket()
        {
            return new BookFifth(price);
        }
    }


}
