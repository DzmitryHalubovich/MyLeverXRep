using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETLeverXLab
{
    public class NumericalsOfaString
    {
        public string GetNumericalString(string str)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                int count = 1;
                for (int j = 0; j < i; j++)
                {
                    if (str[i].Equals(str[j]))
                    {
                        count++;
                    }
                }
                stringBuilder.Append(count.ToString());
            }
            return stringBuilder.ToString();
        }
    }
}
