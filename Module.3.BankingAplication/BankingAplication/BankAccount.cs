using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAplication
{
    public class BankAccount
    {
        AbstractCustomer customer; 
        //Logger logger =new Logger();

        public BankAccount(AbstractCustomer newCustomer)
        {
            customer =  newCustomer.MakeShallowCopy();
        }

        public string ShowInfo()
        {
            return customer.ShowInfo();
        }
        
        public decimal Deposit(decimal amount, int years)
        {
            Logger.Log($"Log: Open a deposit by {customer.FirtsName} {customer.LastName}. " +
                $"Account balance: {Math.Round(customer.Balance,2)}$\nDeposit amount: {amount}$; " +
                $"Deposit term: {years} years; Base rate: {customer.Rate}%.");
            return customer.Deposit(amount, years);
        }

        public decimal Withdraw(decimal amount)
        {
            Logger.Log($"Log: Open a withdraw by {customer.FirtsName} {customer.LastName}. " +
                $"Account balance: {Math.Round(customer.Balance,2)}$\nWithdraw amount: {amount}$");
            return customer.Withdraw(amount);
        }

        public string RequestCredit(decimal amount, int years)
        {
            return customer.RequestCredit(amount, years);
        }


    }
}
