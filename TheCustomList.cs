using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class TheCustomList<T>
    {
        //creating variables could help with the add method
        protected int count;
        protected int capacity;        
        protected T[] items = new T[4];

        public int Count
        {
            get
            {
                return count;
            }
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
        }
        public T this[int x]
        {
            get => items[x];
            set => items[x] = value;
        }
        public TheCustomList()
        {
            count = 0;
            capacity = 4;
            
        }
        public void Add(T item)
        {
            items[count] = item;
            count++;
                        
            if (count == capacity)
            {
                capacity *= 2;
                items = new T[capacity];
            }

        }
    }
}
