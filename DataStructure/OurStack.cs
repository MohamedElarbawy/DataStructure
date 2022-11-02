using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class OurStack<T> //I named it ourStack to avoid conflict with stack class in collections.generics
    {
        int maxSize = 100;
        int top;
        T[] items;
        public OurStack(int size)
        {
            if (size > 0)
                maxSize = size;
            items = new T[maxSize];
            top = -1;
        }


        public void Push(T elment)
        {
           
            if (top > maxSize - 1)
                Console.WriteLine("the stack is full you can't add more elements");
            else
            {
                top++;
                items[top] = elment;

            }
        }


        public void Pop()
        {
            if (top < 0)
                Console.WriteLine("the stack is empty you can't remove any more elements");
            else
            {
                top--;
            }

        }
        public T GetTop()
        {
            if (top < 0)
                Console.WriteLine("the stack is empty you can't get any elements");

            return items[top];
            
        }


        public void Clear()
        {
            top = -1;
        }








    }
}
