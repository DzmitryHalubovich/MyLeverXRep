using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAplication
{
    abstract public class AbstractCustomer
    {
        public class RateForCustomer
        {
            private decimal depositRate;
            private decimal creditRate;
            public decimal DepositRate 
            {
                get
                {
                    return depositRate;
                } 
            } 
            public decimal CreditRate 
            { 
                get
                {
                    return creditRate;
                }
            }
            public RateForCustomer(decimal depositRate, decimal creditRate)
            {
                this.depositRate = depositRate;
                this.creditRate = creditRate;
            }

        }

        public RateForCustomer RateOfCustomer;
        protected string firstName;
        protected string lastName {get;set; }
        protected decimal currentBalance;
        protected int creditHistoryScore =0;
        
        protected int[] allowedDepositPeriod;
        static int SSN = 0; 

        public AbstractCustomer(string firstname,string lastname, decimal balance)
        {
            this.firstName = firstname;
            this.lastName = lastname;
            this.currentBalance = balance;
            SSN++;
        }

        public decimal Rate
        {
            get 
            { 
                return RateOfCustomer.DepositRate; 
            }
        }

        public decimal Balance
        {
            get { return currentBalance; }
        }

        public string FirtsName
        {
            get { return firstName; }
        }

        public string LastName
        {
            get { return lastName; }
        }

        public AbstractCustomer MakeShallowCopy()
        {
            return (AbstractCustomer)this.MemberwiseClone();
        }

        public string ShowInfo()
        {
            return $"Information about customer.\n" +
                $"First name: {firstName}\n" +
                $"Last name: {lastName}\n" +
                $"Balance: {Math.Round(currentBalance, 2)}$\n" +
                $"SSN: {SSN.ToString("{000}-{00}-{0000}")}";
        }

        abstract public decimal Deposit(decimal amount, int years);
        abstract public decimal Withdraw(decimal amount);
        abstract public string RequestCredit(decimal amount, int years);
    }
}
