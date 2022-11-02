using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    /// <summary>
    /// linked list has faster access time and can be expanded in constant time without memory overhead.
    /// Insertion and deletion is easy to implement.
    /// </summary>
    /// <typeparam></typeparam>
    public class OurLinkedList<T> //I named it OurLinkedList to avoid conflict with LinkedList class in collections.generics
    {

        public Node<T>? Head;
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
            if(prevNode == null)
                Console.WriteLine("The given previous node Cannot be null");
            else
            {
            Node<T> newNode = new Node<T>(newItem);
            newNode.next=prevNode.next;
            prevNode.next = newNode;
            }

        }

        public void ReverseLinkedList(OurLinkedList<T> linkedList)
        {
            Node<T>? prev = null;
            Node<T>? currnet = linkedList.Head;
            Node<T>? temp = null;
            while (currnet != null)
            {
                temp=currnet.next;
                currnet.next = prev;
                currnet = temp;
            }
            linkedList.Head = prev;

        }
        


    }


   
}
