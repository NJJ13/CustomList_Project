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
            get
            {
                if (x < 0 || x >= count)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                return items[x];
            }
            set
            {
                if (x < 0 || x >= count)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                items[x] = value;
            }
        }
        public TheCustomList()
        {
            count = 0;
            capacity = 4;
            
        }
        public void Add(T item)
        {
            if (count == capacity)
            {
                capacity *= 2;
                T[] copyArray = new T[capacity];
                for (int i = 0; i <= capacity; i++)
                {
                    copyArray[i] = items[i];
                }
                items = copyArray;
            }
            items[count] = item;
            count++;
                        

        }
        public void Remove(T item)
        {
           T[] copyArray = new T[capacity];
           for (int i = 0; i <= count; i++)
           {
                if (item.Equals(items[i]))
                {
                    for (int j = i; j < (count-1); j++)
                    {
                        copyArray[j] = items[j+1];
                    }
                    
                    break;
                }
                copyArray[i] = items[i];
                
           }
            items = copyArray;
            count--;
        }
    }
}
