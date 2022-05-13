using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAplication.Customers
{
    public class VIPCustomer : AbstractCustomer
    {
        class RateOfVipCustomer
        {
            public decimal DepositRate { get; } = 0.1m;
            public decimal CreditRate { get; } = 0.2m;
        }

        public VIPCustomer(string firstname, string lastname, decimal currentBalance) : base(firstname, lastname, currentBalance)
        {
            RateOfCustomer = new RateForCustomer(0.1m, 0.08m);
            allowedDepositPeriod =  new int[] { 1,2,3,5,7 }; 
        }

        public override decimal Deposit(decimal amount, int years)
        {
            if (!allowedDepositPeriod.Any(x => x == years))
            {
                Logger.Log("Sorry! We can't provide you with a deposit for the specified period!"); //Change message
                return 0;
            }
            if (amount > 0 && amount <= currentBalance)
            {
                decimal totalAmount = amount;
                decimal totalRate = 0;
                for (int i = 0; i < years; i++)
                {
                    totalRate = (totalAmount*RateOfCustomer.DepositRate);
                    totalAmount += totalRate;
                }
                currentBalance+=totalAmount; //currentBalance-=totalAmount; for future
                return Math.Round(totalAmount, 2);
            }
            return 0;
        }

        //Исправить
        public override string RequestCredit(decimal requestAmountOfCredit, int creditPeriod)
        {
            if (requestAmountOfCredit > currentBalance/2 || requestAmountOfCredit <= 0 ||  !allowedDepositPeriod.Any(x => x == creditPeriod))
            {
                return "Sorry, we can't provide you a credit=(";
            }
            if (CreditDepartment.RequestPermissionForVipCustomer(creditHistoryScore))
            {
                decimal debt = requestAmountOfCredit;
                debt += requestAmountOfCredit*RateOfCustomer.CreditRate;
                creditHistoryScore++;
                Logger.Log($"credit history score: {creditHistoryScore}");
                return $"Can give you credit for {requestAmountOfCredit}$ on {creditPeriod}. " +
                    $"Debt: {debt}$";
            }
            return "Sorry, the department does not give permission to provide a credit for you=(";
        }

        public override decimal Withdraw(decimal amount)
        {
            decimal cash;
            if (amount<=currentBalance)
            {
                cash = amount;
                currentBalance-=cash;
                Logger.Log("Log: Withdraw operation completed successfully!");
                return cash;
            }
            Logger.Log("Log: It is impossible to perform the operation!");
            return 0;
        }
    }
}
