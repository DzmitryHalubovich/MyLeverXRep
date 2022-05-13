using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAplication
{
    public class CreditDepartment
    {
        public static bool RequestPermissionForOrdinaryCustomer(int creditHistoryScore)
        {
            Random random = new Random();
            if(creditHistoryScore<6) 
            {
                var scoreShoulBeMoreThanThree = random.Next(creditHistoryScore, 6);
                if(scoreShoulBeMoreThanThree >3)
                {
                    return true;
                }
            }
            else
            {
                return true;
            }

            return false;
        }


        public static bool RequestPermissionForVipCustomer(int creditHistoryScore)
        {
            Random random = new Random();
            if (creditHistoryScore<2) 
            {
                var scoreShoulBeMoreThanOne = random.Next(creditHistoryScore, 4);
                if (scoreShoulBeMoreThanOne > 1)
                {
                    return true;
                }
            }
            else
            {
                return true;
            }

            return false;
        }

        public static bool RequestPermissionForEntrepreneur(int creditHistoryScore)
        {
            Random random = new Random();
            if (creditHistoryScore<4) 
            {
                var scoreShoulBeMoreThanFour = random.Next(creditHistoryScore, 10);
                if (scoreShoulBeMoreThanFour > 4)
                {
                    return true;
                }
            }
            else
            {
                return true;
            }

            return false;
        }

    }
}
