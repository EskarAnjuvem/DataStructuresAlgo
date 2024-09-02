using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace List
{
    public class CustomArrayList<T>
    {
        private T[] arr;
        public const int INITIAL_CAPACITY = 4;
        private int count;
        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public CustomArrayList(int capacity = INITIAL_CAPACITY)
        {
            this.arr = new T[capacity];
            this.count = 0;
        }

        public void Add(T item)
        {
            GrowIfArrIsFull();
            this.arr[count] = item;
            this.count++;
        }

        public void Insert(T item, int index)
        {
            if (index > this.count || index < 0)
            {
                throw new IndexOutOfRangeException("Invalid Index: " + index);
            }
            GrowIfArrIsFull();
            Array.Copy(this.arr, index, this.arr, index + 1, this.count - index);
            this.arr[index] = item;
            this.count++;
        }

        public T RemoveAt(int index)
        {
            if( index >= this.count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid Index : " + index);
            }
            T item = this.arr[index];

            Array.Copy(this.arr, index + 1, this.arr, index, this.count - index - 1);
            this.arr[this.count - 1] = default(T);
            this.count--;
            return item;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < this.arr.Length; i++)
            {
                if (Object.Equals(this.arr[i], item))
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Contains(T item)
        {
            bool result = ((IndexOf(item)) != -1);
            return result;
        }
        
        public T this[int index]
        {
            get
            {
                if (index >= this.count || index > 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid index " + index);
                }
                return this.arr[index];
            }
            set 
            {
                if (index >= this.count || index > 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid index " + index);
                }
                this.arr[index] = value;
            }
        }

        public void DisplayList()
        {
            for (int i = 0; i < this.count; i++)
            {
                Console.WriteLine(" -> "+ arr[i]);
            }
        }
        private void GrowIfArrIsFull()
        {
            if ((this.count + 1) > (this.arr.Length))
            {
                T[] newArray = new T[this.arr.Length * 2];
                Array.Copy(this.arr, newArray, this.count);
                this.arr = newArray;
            }
        }

        public void Clear()
        {
            this.arr = new T[INITIAL_CAPACITY];
            this.count = 0;
        }
    }
}
