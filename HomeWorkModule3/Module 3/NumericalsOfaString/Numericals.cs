using System;

namespace NumericalsOfaString
{
    public class Numericals
    {
        public string GetNumericalString(string str)
        {
            string answ = "";
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
                answ += count.ToString();
            }
            return answ;
        }
    }
}
