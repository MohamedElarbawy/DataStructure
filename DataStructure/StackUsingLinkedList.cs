using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class StackUsingLinkedList<T>
    {
        Node<T>? top;
        public StackUsingLinkedList()
        {
            top = null;
        }

        public void Push(T element)
        {
            Node<T> newNode=new Node<T>(element);
            if (top == null)
                newNode.next = null;
            else
            {
                newNode.next = this.top;
            }
            top = newNode;
        }
        public void Pop()
        {
            if (top == null)
                Console.WriteLine("the stack is empty you can't pop any elements");
            else
                top = top.next;
        }

        public T GetTop()
        {
            if (top ==null)
                Console.WriteLine("the stack is empty you can't get any elements");

            return top.item;

        }

    }
}
