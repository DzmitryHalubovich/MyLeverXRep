using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETLeverXLab
{
    public class CountIPAddresses
    {
        public int CountIP(string firstIpAddress, string secondIpAddress)
        {
            string[] splitFirstAddress = firstIpAddress.Split('.');
            string[] splitSecondAddress = secondIpAddress.Split('.');

            int countIpOfFirstAddress = (Convert.ToInt32(splitFirstAddress[0]) * (256 * 3)) + (Convert.ToInt32(splitFirstAddress[1]) * (256 * 2)) + (Convert.ToInt32(splitFirstAddress[2]) * 256) + Convert.ToInt32(splitFirstAddress[3]) + 1;
            int countIpOfSecondAddress = (Convert.ToInt32(splitSecondAddress[0]) * (256 * 3)) + (Convert.ToInt32(splitSecondAddress[1]) * (256 * 2)) + (Convert.ToInt32(splitSecondAddress[2]) * 256) + Convert.ToInt32(splitSecondAddress[3]) + 1;

            if (countIpOfFirstAddress > countIpOfSecondAddress) { return 0; }
            
            return countIpOfSecondAddress - countIpOfFirstAddress;
        }
    }
}
