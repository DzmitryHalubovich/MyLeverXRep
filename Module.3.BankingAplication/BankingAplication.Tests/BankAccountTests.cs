using Xunit;

namespace BankingAplication.Tests
{
    public class BankingAplicationTests : AbstractCustomer
    {
        public BankingAplicationTests(string firstname, string lastname, decimal balance) : base(firstname, lastname, balance)
        {

        }

        public override decimal Deposit(decimal amount, int years)
        {
            throw new System.NotImplementedException();
        }

        public override string RequestCredit(decimal amount, int years)
        {
            throw new System.NotImplementedException();
        }

        public override decimal Withdraw(decimal amount)
        {
            throw new System.NotImplementedException();
        }
    }

    public class BankAccountTests
    {
        [Fact]
        public void OrdinaryCustomer_Deposit_GetDeposit()
        {
            //Arrange
            BankAccount account = new BankAccount(new OrdinaryCustomer("Ivan", "Abramov", 5000));

            //Act
            var testDeposit = account.Deposit(100,3);

            //Assert
            Assert.Equal(115.76m, testDeposit);
        }

        [Fact]
        public void OrdinaryCustomer_Deposit_GetZeroWhenCantGetDeposit()
        {
            //Arrange
            BankAccount account = new BankAccount(new OrdinaryCustomer("Ivan", "Abramov", 100));

            //Act
            var testDeposit = account.Deposit(200, 2);

            //Assert
            Assert.Equal(0, testDeposit);
        }

        [Fact]
        public void OrdinaryCustomer_Withdraw_GetMoney()
        {
            
            BankAccount account = new BankAccount(new OrdinaryCustomer("Ivan", "Abramov", 500));

            var actual = account.Withdraw(300);

            Assert.Equal(300m, actual);
        }

        [Fact]
        public void OrdinaryCustomer_ShowInfo()
        {
            BankAccount account = new BankAccount(new OrdinaryCustomer("Ivan", "Abramov", 500));
            var info = account.ShowInfo();
            Assert.Equal(info, account.ShowInfo());
        }


    }
}