using System;
using TestingPart2BankAccount.Interfaces;

namespace TestingPart2BankAccount
{
    public class Logger
    {
        public static void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class BankAccount
    {
        abstract class Customers
        {
            protected string FirstName { get; set; }
            protected string SecondName { get; set; }
            protected string SSN { get; set; }
            protected decimal Balance { get; set; }
            protected double RatePercents { get; set; }
        }

        class Ordinary : Customers, ISetRate, IGetInformation
        {
            public Ordinary(string firstName,string secondName, decimal balance) 
            {
                FirstName = firstName;
                SecondName = secondName;
                Balance = balance;
                RatePercents = 5;
            }

            public void GetInformation()
            {
                Console.WriteLine($"First name: {FirstName}\n" +
                                  $"Second name: {SecondName}\n" +
                                  $"Balance: {Balance}\n" +
                                  $"SSN: {SSN}");
            }
        }

        class Entepreneur : Customers
        {
            public Entepreneur(string firstName, string secondName, decimal balance)
            {
                FirstName = firstName;
                SecondName = secondName;
                Balance = balance;
                RatePercents = 7; 
            }
        }

        class VIP : Customers
        {
            public VIP(string firstName, string secondName, decimal balance)
            {
                FirstName = firstName;
                SecondName = secondName;
                Balance = balance;
                RatePercents = 10;
            }
        }

    }


}
