using System;

namespace BookShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Установите цену за одну книгу (в EUR): ");
            double setPrice = double.Parse(Console.ReadLine());
            var bookShop = new Book(setPrice);

            bookShop.PrintPrice();

            Basket basket = new AddFirstBookToBasket();
            basket.AddToBasket();
            basket.AddToBasket();
            basket = new AddSecondBookToBasket();
            basket.AddToBasket();
            basket = new AddThirdBookToBasket();
            basket.AddToBasket();
            basket = new AddFourthBookToBasket();
            basket.AddToBasket();
            basket = new AddFifthBookToBasket();
            basket.AddToBasket();

            var booksList = bookShop.ReturnList();
            Console.WriteLine("Количество книг: " + booksList.Count);
            Console.WriteLine(bookShop.Purchase());

            


        }
    }
}
