using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_TIRGOL
{
    class SortedClass<T> where T : struct
    {
        public T[] MyArray { get; set; } = new T[10];
        private int Count  = 9;

        public void AddItem(T item)
        {
            
            MyArray[Count] = item;
            Count--;
            Array.Sort(MyArray);
        
        }



    }
}
