using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace lab_05
{
    internal class MyList <T> : IEnumerable<T>
    {
        T[] arr;
        int size;
        int e;

        public T this[int i]
        {
            get
            {
                if (e < i)
                {
                    return arr[e];
                }

                throw new IndexOutOfRangeException();
            }
        }

        public MyList(int s = 5)
        {
            e = 0;
            size = 5;
            arr = new T[s];

        }

        public void add(T d)
        {
            if (e < size)
            {
                arr[e] = d;
                e++;
            }
            else
            {
                size *= 2;
                T[] arr1 = new T[size];

                for (int i = 0; i < e; i++)
                {
                    arr1[i] = arr[i];
                }
                arr = arr1;
                arr[e] = d;
                e++;

            }
        }

        public void Remove(T d)
        {
            for (int i = 0; i < e; i++)
            {
                if (d.Equals(arr[i]))
                {
                    for (int j = i + 1; j < e; j++)
                    {
                        arr[j - 1] = arr[j];
                    }
                    e--;
                    break;
                }
            }
        }

        // findall
        public MyList<T> FindAll(Func<T, bool> condition)
        {
            MyList<T> result = new MyList<T>();

            for (int i = 0; i < e; i++)
            {
                if (condition(arr[i]))
                {
                    result.add(arr[i]);
                }
            }

            return result;
        }


        public void Print()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return (IEnumerator<T>) arr.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
