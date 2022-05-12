using System;

namespace CommonTests
{
    public class PassportData 
    {
        public DateTime IssuedDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Number { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}