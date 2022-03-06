using NUnit.Framework;
using CountIPAddresses;

namespace CountIPAddresses.Tests
{
    public class Tests
    {
        [Test]
        public void CountAddresses_CountIP_GetCountsAddresses()
        {
            //Arrange 
            var ipAdress = new CountAddresses();

            string _firtsTestIp = "0.0.0.2";
            int _expectedCountFirstTestIp = 3;

            //Act

            var actual = ipAdress.GetIP(_firtsTestIp.Split('.'));

            //Assert

            Assert.AreEqual(_expectedCountFirstTestIp,actual);
        }
    }
}