using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NETLeverXLab;
using NUnit;
using NUnit.Framework;

namespace LibraryModuleOne.Tests
{
    [TestFixture]
    class CountIPAddressesTests
    {
        [TestCase("10.0.0.0", "10.0.0.50", 50)]
        [TestCase("10.0.0.0", "10.0.1.0", 256)]
        [TestCase("10.0.1.0", "10.0.0.0", 0)]
        public void CountIPAddresses_CountIP_GetCountOfIpAddresses(string firstAddress, string secondAddress, int expectedCount)
        {
            //Arrange
            var countIP = new CountIPAddresses();

            //Act
            var returnValue = countIP.CountIP(firstAddress, secondAddress);

            //Assert
            Assert.AreEqual(expectedCount, returnValue);
        }
    }
}
