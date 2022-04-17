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
        protected string FirstName { get; set; }
        protected string SecondName { get; set; }
        protected string SSN { get; set; }
        protected decimal Balance { get; set; }

        public void CreateAcc(string firstName, string secondName, decimal balance)
        {

        }
    }
    //нужен метод, который создаст аккаунт и вернет указатель на него
    abstract public class Costumers : BankAccount
    {
        public BankAccount bankAccount = new BankAccount();



       protected Costumers(string firstName, string secondName, decimal balance)
        {
            bankAccount.CreateAcc(firstName, secondName, balance);
        }

    }

    public class Ordinary : Costumers, IGetSSN, ICheckAccount
    {

        Ordinary(string firstName, string secondName, decimal balance) : base(firstName, secondName, balance) { }

        public decimal GetAmountOnTheAccount()
        {
            throw new NotImplementedException();
        }

        public string GetSSN()
        {
            throw new NotImplementedException();
        }
    }
}
