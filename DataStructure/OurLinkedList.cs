using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class OurLinkedList<T> //I named it OurLinkedList to avoid conflict with LinkedList class in collections.generics
    {

        public Node<T> Head;
        public void InsertFront(OurLinkedList<T> linkedList, T newItem)
        {
            Node<T> newNode = new Node<T>(newItem);
            newNode.next = linkedList.Head;
            linkedList.Head = newNode;
        }

        public void InsertLast(OurLinkedList<T> linkedList, T newItem)
        {
            Node<T> newNode = new Node<T>(newItem);
            if (linkedList.Head == null)
                linkedList.Head = newNode;
            else
            {
                Node<T> lastNode = GetLastNode(linkedList);
                lastNode.next = newNode;
            }
        }
        Node<T> GetLastNode(OurLinkedList<T> linkedList)
        {
            Node<T> temp = linkedList.Head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        public void InsertAfter(Node<T> prevNode,T newItem)
        {
            Node<T> newNode = new Node<T>(newItem);
            newNode.next=prevNode.next;
            prevNode.next = newNode;

        }


        


    }


    public class Node<T>
    {
       public T item;
        public Node<T>? next;
        public Node(T item)
        {
            this.item = item;
            next = null;

        }
    }
}
