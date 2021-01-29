using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class TheCustomList<T> : IEnumerable
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
        public IEnumerator GetEnumerator()
        {
            foreach (T item in items)
            {
                yield return item;
            }
        }
          
        public void Add(T item)
        {
            if (count == capacity)
            {
                capacity *= 2;
                T[] copyArray = new T[capacity];
                for (int i = 0; i <= (count - 1); i++)
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
                    count--;
                    break;
                }
                copyArray[i] = items[i];
                
           }
            items = copyArray;
            
            
        }
        public override string ToString()
        {

            string x = "";
            for (int i = 0; i < count; i++)
            {
                x += items[i].ToString();
            }
            
            return x;
        }
        public static TheCustomList<T> operator +(TheCustomList<T> list1, TheCustomList<T> list2)
        {
            TheCustomList<T> result = new TheCustomList<T>();

            for (int i = 0; i < list1.count; i++)
            {
                result.Add(list1[i]);
            }
            for (int i = 0; i < list2.count; i++)
            {
                result.Add(list2[i]);
            }
            return result;
        }
        public static TheCustomList<T> operator -(TheCustomList<T> x, TheCustomList<T> y)
        {
            TheCustomList<T> result = new TheCustomList<T>();
            result = x;
            for (int i = 0; i < result.count; i++)
            {
                for (int j = 0; j < y.count; j++)
                {
                    if (result[i].Equals(y[j]))
                    {
                        result.Remove(y[j]);
                    }
                }
            }
              return result;
        }
        public void Zip(TheCustomList<T> list)
        {
            TheCustomList<T> copyList = new TheCustomList<T>();
            int x;
            if (count > list.count)
            {
                x = count;
            }
            else
            {
                x = list.count;
            }
            
            for (int i = 0; i < x ; i++)
            {
                if(i < count)
                {
                    copyList.Add(items[i]);
                }
                if(i < list.count)
                {
                    copyList.Add(list[i]);
                }
            }
            count = copyList.count;
            capacity = copyList.capacity;
            items = copyList.items;
        }
        public static void Swap(T[] array, int item1, int item2)
        {
            T holder;
            holder = array[item1];
            array[item1] = array[item2];
            array[item2] = holder;
        }
        public void AscendSortIntList(TheCustomList<int> list)
        {
            for (int i = 0; i < count; i++)
            {
                for (int j = i+1; j < count; j++)
                {
                    if (list.items[i] > list.items[j])
                    {
                        Swap(items, i, j);
                    }
                }
            }
        }
        public void DescendSortIntList(TheCustomList<int> list)
        {
            for (int i = 0; i < count; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (list.items[i] < list.items[j])
                    {
                        Swap(items, i, j);
                    }
                }
            }
        }
        public void AscendSortStringLengthList(TheCustomList<string> list)
        {
            for (int i = 0; i < count; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (list.items[i].Length > list.items[j].Length)
                    {
                        Swap(items, i, j);
                    }
                }
            }
        }
        public void DescendSortStringLengthList(TheCustomList<string> list)
        {
            for (int i = 0; i < count; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (list.items[i].Length < list.items[j].Length)
                    {
                        Swap(items, i, j);
                    }
                }
            }
        }
    }
}
