using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingPart2BankAccount
{
    class ProgramDELETEAFTERITLLDONE
    {
        static void Main(string[] args)
        {
            Customers cust = new Ordinary("Thomas", "Anderson", 500);
            Console.WriteLine(cust.GetInformation());
        }

        
    }
}
