using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingPart2BankAccount.Interfaces
{
    public interface IDeposit
    {
        public decimal GetDeposit(double rate, decimal amount, decimal balance, int years)
        {
            if (amount > 0 && amount <= balance)
            {
                decimal totalAmount = amount;
                decimal totalRate = 0;
                for (int i = 0; i < years; i++)
                {
                    totalRate = (totalAmount*(decimal)rate)/100;
                    totalAmount += totalRate;
                }

                return totalAmount;
            }

            return -1;
        }
    }
}
