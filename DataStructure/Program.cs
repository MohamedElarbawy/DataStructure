using DataStructure;


//OurStack<int> s = new OurStack<int>(50);
//s.Push(1);
//s.Push(2);
//s.Push(3);
//s.Pop();
//s.Push(4);
//s.Pop();
//Console.WriteLine(s.GetTop());




//OurLinkedList<int> ourLinkedList = new OurLinkedList<int>();
//ourLinkedList.InsertLast(ourLinkedList,5);
//ourLinkedList.InsertLast(ourLinkedList,9);
//ourLinkedList.InsertLast(ourLinkedList,6);


//OurQueue<string> q = new OurQueue<string>(50);
//q.Enqueue("hi");
//q.Enqueue("I");
//q.Enqueue("am");
//q.Dequeue();
//q.Enqueue("mohamed");
//q.PrintQueue();



DoublyLinkedList<int> dlist=new DoublyLinkedList<int>();
dlist.InsertFront(dlist,5);
dlist.InsertFront(dlist,10);
dlist.InsertFront(dlist,15);
dlist.InsertAfter(dlist.head, 7);
dlist.InsertLast(dlist, 20);
