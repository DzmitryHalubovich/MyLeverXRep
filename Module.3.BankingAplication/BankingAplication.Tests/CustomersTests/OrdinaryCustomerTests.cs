using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankingAplication.Tests
{
    public class OrdinaryCustomerTests
    {
        [Fact]
        public void OrdinaryCustomer_Deposit_GetDeposit()
        {
            OrdinaryCustomer customer = new OrdinaryCustomer("Ivan", "Abramov", 5000);

            var actual = customer.Deposit(300,2);

            Assert.Equal(330.75m,actual);
        }

        [Fact]
        public void OrdinaryCustomer_Deposit_GetZeroWhenRequestWrondPeriod()
        {
            OrdinaryCustomer customer = new OrdinaryCustomer("Ivan", "Abramov", 5000);

            var actual = customer.Deposit(200,4);

            Assert.Equal(0, actual);
        }

        [Fact]
        public void OrdinaryCustomer_Withdraw_GetWithdraw()
        {
            OrdinaryCustomer customer = new OrdinaryCustomer("Ivan", "Abramov", 5000);

            var actual = customer.Withdraw(300);

            Assert.Equal(300, actual);
        }

        [Fact]
        public void OrdinaryCustomer_Withdraw_GetZeroWithdrawIfAmountMoreThenAllowed()
        {
            OrdinaryCustomer customer = new OrdinaryCustomer("Ivan", "Abramov", 5000);

            var actual = customer.Withdraw(500);

            Assert.Equal(0, actual);
        }

        

        [Fact]
        public void OrdinaryCustomer_Features()
        {
            OrdinaryCustomer customer = new OrdinaryCustomer("Ivan", "Abramov", 5000);

            var actualRate = customer.Rate;
            var actualBalance = customer.Balance;
            var actualLastName = customer.LastName;
            var actualFirstName = customer.FirtsName;

            Assert.NotNull(actualRate);
            Assert.NotNull(actualBalance);
            Assert.NotNull(actualLastName);
            Assert.NotNull(actualFirstName);
        }


    }
}
