using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingPart2BankAccount.Interfaces;
using Xunit;

namespace TestingPart2BankAccount.Tests
{
    //public decimal GetDeposit(double rate, decimal amount, decimal balance, int years)
     class TryGetDepositeStub : IDeposit
    {
        public double stubRate = 5;
        public decimal stubAmount = 300;
        public decimal stubBalance = 500;
        public int stubYears = 2;

        public double stubRate1 = 5;
        public decimal stubAmount1 = 300;
        public decimal stubBalance1 = 200;
        public int stubYears1 = 2;

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

    public class IDepositTests
    {
        [Fact]
        public void IDeposit_GetDeposit_GetAmountAfterSeveralYears()
        {
            //Arrange
            var stubDeposite = new TryGetDepositeStub();
            decimal expectedAmount = 330.75m;

            //Act

            //public decimal GetDeposit(double rate, decimal amount, decimal balance, int years)
            var actual = stubDeposite.GetDeposit(stubDeposite.stubRate, stubDeposite.stubAmount, stubDeposite.stubBalance, stubDeposite.stubYears);

            //Assert
            Assert.Equal(expectedAmount, actual);
        }

        [Fact]
        public void IDeposit_GetDeposit_GetFail()
        {
            //Arrange
            var stubDeposite = new TryGetDepositeStub();
            decimal expectedAmount = -1;

            //Act

            //public decimal GetDeposit(double rate, decimal amount, decimal balance, int years)
            var actual = stubDeposite.GetDeposit(stubDeposite.stubRate1, stubDeposite.stubAmount1, stubDeposite.stubBalance1, stubDeposite.stubYears1);

            //Assert
            Assert.Equal(expectedAmount, actual);
        }
    }
}
