using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{
    public class MyList<T> : List<T>
    {
        public void Shuffle()
        {
            Random rand = new Random();

            for (int i = this.Count - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);

                T tmp = this[j];
                this[j] = this[i];
                this[i] = tmp;
            }
        }
    }

}
