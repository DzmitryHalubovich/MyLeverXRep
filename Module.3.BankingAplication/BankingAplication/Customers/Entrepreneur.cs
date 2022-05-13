using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAplication.Customers
{
    public class Entrepreneur : AbstractCustomer
    {
        RateForCustomer RateOfCustomer;
        public Entrepreneur(string firstName, string lastName, decimal currentBalance) : base(firstName, lastName, currentBalance)
        {
            RateOfCustomer = new RateForCustomer(0.05m, 0.2m);
            allowedDepositPeriod = new int[] { 3, 5, 7, 10 }; 
        }

        public override decimal Deposit(decimal requestDepositAmount, int depositPeriodInYears)
        {
            if (!allowedDepositPeriod.Any(x => x == depositPeriodInYears))
            {
                Logger.Log("Sorry! We can't provide you with a deposit for the specified period!"); //Change message
                return 0;
            }
            if (requestDepositAmount > 0 && requestDepositAmount <= currentBalance)
            {
                decimal totalAmount = requestDepositAmount;
                decimal totalRate = 0;
                for (int i = 0; i < depositPeriodInYears; i++)
                {
                    totalRate = (totalAmount*RateOfCustomer.DepositRate);
                    totalAmount += totalRate;
                }
                currentBalance+=totalAmount; //currentBalance-=totalAmount; for future
                return Math.Round(totalAmount, 2);
            }
            return 0;
        }

        public override string RequestCredit(decimal requestAmountOfCredit, int creditPeriod)
        {
            if (requestAmountOfCredit > currentBalance/3 || requestAmountOfCredit <= 0 ||  !allowedDepositPeriod.Any(x => x == creditPeriod))
            {
                return "Sorry, we can't provide you a credit=(";
            }
            if (CreditDepartment.RequestPermissionForOrdinaryCustomer(creditHistoryScore))
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
