using System;
using System.Collections;
using System.Collections.Generic;
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

    abstract public class Customers
    {
        protected string FirstName { get; set; }
        protected string SecondName { get; set; }

        protected static int SSN;
        protected decimal Balance { get; set; }
        protected double RatePercents { get; set; }


        public string GetInformation()
        {
            return $"First name: {FirstName}\n " +
                $"Second name: {SecondName}\n " +
                $"Balance: {Balance}\n " +
                $"SSN: {SSN.ToString("{000}-{00}-{0000}")}";
        }

       
    }

    public class Ordinary : Customers, ISetRate, IGetInformation, IWithdraw
    {
        public Ordinary(decimal balance) { Balance = balance; }

        public Ordinary(string firstName, string secondName, decimal balance)
        {
            FirstName = firstName;
            SecondName = secondName;
            Balance = balance;
            RatePercents = 5;
            SSN++;
        }

        public decimal Withdraw(decimal amount)
        {
            decimal amountForOrdinary = 400;
            try
            {
                if (amountForOrdinary < amount || amount > Balance || amount < 0)
                {
                    throw new Exception("Incorrect amount");
                }
                Balance-=amount;
                return amount;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}!");
            }
            return 0;
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

    public class BankAccount 
    {

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
