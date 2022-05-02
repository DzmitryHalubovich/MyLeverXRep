using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETLeverXLab
{
    public class Unique
    {
        public IEnumerable<T> uniq<T>(IEnumerable<T> input)
        {
            List<T> list = new List<T>();
            list.Add(input.First());
            foreach (var item in input)
            {
                if (!item.Equals(list.Last()))
                {
                    list.Add(item);
                }
            }
            return list;
        }
    }
}
