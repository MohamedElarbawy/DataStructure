using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class QueueUsingLinkedList<T>
    {
        Node<T>? first;
        Node<T>? last;
        public QueueUsingLinkedList()
        {
            first = null;
            last = null;
        }

        public void Enqueue(T elemet)
        {
            Node<T> newNode = new Node<T>(elemet);
            if(last == null)
                first=last=newNode;
            else
            {
                last.next = newNode;
                last = newNode;
            }
        }


        public void Dequeue()
        {
            if(first == null)
                Console.WriteLine("the queue is empty you can't dequeue");
            else
                first=first.next;
            //if the queue bacame empty change last to be null
            if(first==null)
                last=null;
            
        }


        public T GetFirst()
        {
            if(first==null)
                Console.WriteLine("thq queue is empty");
            return first.item;
        }
        public T GetLast()
        {
            if(last==null)
                Console.WriteLine("thq queue is empty");
            return last.item;
        }





    }
}
