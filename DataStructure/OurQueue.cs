using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{//queue implementation using circular array
    public class OurQueue<T> //I named it OurQueue to avoid conflict with Queue class in collections.generics
    {
        int maxSize=100;
        int first;
        int last;
        int count;
        T[] arr;
       
        public OurQueue(int size)
        {
           if(size>0)
                maxSize = size;
            arr = new T[maxSize];
            first = 0;
            last = maxSize - 1;
            count = 0;
        }
        public bool IsEmpty() => count == 0;
        public bool IsFull() => count == maxSize;
        public void Enqueue(T newElement)
        {
            if (IsFull())
                Console.WriteLine("the queue is full you can't add more elements");
            else
            {
                last = (last + 1) % maxSize;
                arr[last] = newElement;
                count++;
            }
        }
        public void Dequeue()
        {
            if (IsEmpty())
                Console.WriteLine("the queue is already empty you can't delete any elemnts");
            else
            {
                first = (first + 1) % maxSize;
                count--;
            }
        }

        public T GetFirst()
        {
            if (IsEmpty())
                Console.WriteLine("thq queue is empty");
            return arr[first];
        }
        public T GetLast()
        {
            if (IsEmpty())
                Console.WriteLine("thq queue is empty");
            return arr[last];
        }
        public void PrintArray()
        {
            for (int i = first; i!= last+1; i=(i+1)%maxSize)
            {
                Console.WriteLine(arr[i]);
            }
        }

    }
}
