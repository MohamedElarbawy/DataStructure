using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class DoublyLinkedList<T>
    {
        public DoubleNode<T>? head;

        public void InsertFront(DoublyLinkedList<T> dLinkedList,T element)
        {
            DoubleNode<T> newNode=new DoubleNode<T>(element);
            newNode.next = dLinkedList.head;
            newNode.prev = null;
            if(dLinkedList.head != null)
                dLinkedList.head.prev = newNode;
            dLinkedList.head = newNode; 

        }
        public void InsertLast(DoublyLinkedList<T> dLinkeList,T element)
        {
            DoubleNode<T> newNode = new DoubleNode<T>(element);
            if (dLinkeList.head == null)
                dLinkeList.head = newNode;
            else
            {
            DoubleNode<T> lastNode=GetLastNode(dLinkeList);
            lastNode.next = newNode;
            newNode.prev = lastNode;
            }

        }

        DoubleNode<T> GetLastNode(DoublyLinkedList<T> dLinkedList)
        {
            DoubleNode<T>? temp=dLinkedList.head;
            while(temp.next != null)
                temp=temp.next;
            return temp;
        }

        public void InsertAfter(DoubleNode<T> prevNode,T element)
        {
            if (prevNode == null)
                Console.WriteLine("The given previous node Cannot be null");
            else
            {
                DoubleNode<T> newNode = new DoubleNode<T>(element);
                newNode.next = prevNode.next;
                prevNode.next=newNode;
                newNode.prev = prevNode;
                if (newNode.next != null)
                    newNode.next.prev = newNode;
            }
        }






    }
}
