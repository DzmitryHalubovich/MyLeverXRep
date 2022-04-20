using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestingPart2BankAccount.Tests
{
    public class IWithdrawTests
    {
        [Fact]
        public void IWithdraw_Withdraw_GetMoney()
        {
            //Arrange
            Ordinary cust = new Ordinary(500);
            decimal expected = 200;

            //Act
            var actual = cust.Withdraw(200);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IWithdraw_Withdraw_GetZero()
        {
            //Arrange
            Ordinary cust = new Ordinary(600);
            decimal expected = 0;

            //Act
            var actual = cust.Withdraw(450);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
