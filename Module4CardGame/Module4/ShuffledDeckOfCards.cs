using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{
    //public class ShuffledDeckOfCards
    //{

    //    List<int> myList = new List<int>();

    //    public List<int> GetShuffle()
    //    {
    //        return myList;
    //    }

    //    // создаем экземпляр класса Random для генерирования случайных чисел
    //    public void Shuffle(List<int> list)
    //    {
    //        Random rand = new Random();

    //        for (int i = list.Count - 1; i >= 1; i--)
    //        {
    //            int j = rand.Next(i + 1);

    //            int tmp = list[j];
    //            list[j] = list[i];
    //            list[i] = tmp;
    //        }
    //    }
    //}

    public class MyList<T> : List<T>
    {
        //readonly MyList<int> list;
        //public MyList<int> Initialization()
        //{
        //    for (int i = 0; i < 4; i++) //Инициализируем массив (Я для себя пишу комменты, по этому на русском)
        //    {
        //        for (int j = 1; j < 11; j++)
        //        {
        //            list.Add(j);
        //        }
        //    }
        //    return list;
        //}

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
