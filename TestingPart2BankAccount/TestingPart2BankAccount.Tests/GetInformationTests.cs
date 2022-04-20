using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestingPart2BankAccount.Tests
{
    
    public class StubOrdinary
    {
        string FirstName = "Thomas";
        string SecondName = "Anderson";
        decimal Balance = 500m;
        int SSN = 000000001;

        public string GetInformation()
        {
            return $"First name: {FirstName}\n " +
                $"Second name: {SecondName}\n " +
                $"Balance: {Balance}\n " +
                $"SSN: {SSN.ToString("{000}-{00}-{0000}")}";
        }

    }


    public class GetInformationTests
    {
        [Fact]
        public void GetInformation_ReturnStringWithInformation()
        {
            //Arrange
            var test = new StubOrdinary();
            string expectedString = "First name: Thomas\n Second name: Anderson\n Balance: 500\n SSN: {000}-{00}-{0001}";
                
            //Act
            var actual = test.GetInformation();

            //Assert
            Assert.Equal(expectedString,actual);
        }
    }
}
