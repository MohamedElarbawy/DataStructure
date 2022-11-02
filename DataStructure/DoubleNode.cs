using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    //this node points to the previous node and the next node
    public class DoubleNode<T>
    {
        public T item;
        public DoubleNode<T>? prev;
        public DoubleNode<T>? next;
        public DoubleNode(T item)
        {
            this.item = item;
            prev = null;
            next = null;
        }

    }
}
