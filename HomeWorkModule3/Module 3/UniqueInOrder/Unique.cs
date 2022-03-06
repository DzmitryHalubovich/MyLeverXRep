using System;
using System.Collections.Generic;
using System.Linq;

namespace UniqueInOrder
{
    public class Unique
    {
        public List<dynamic> uniqueInOrder(dynamic str)
        {
            var uniq = new List<dynamic>();

            for (int i = 0; i < str.Length; ++i)
            {
                if (uniq.Count == 0)
                {
                    uniq.Add(str[i]);
                }
                if (uniq.Last() != str[i])
                {
                    uniq.Add(str[i]);
                }
            }

            return uniq;
        }
    }
}
