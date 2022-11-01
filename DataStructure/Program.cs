using DataStructure;

 
OurStack<int> s= new OurStack<int>();
s.Push(1);
s.Push(2);
s.Push(3);
s.Pop();
s.Push(4);
s.Pop();
Console.WriteLine(s.GetTop());
s.Clear();
Console.WriteLine(s.GetTop());



OurLinkedList<int> ourLinkedList = new OurLinkedList<int>();
ourLinkedList.InsertLast(ourLinkedList,5);
ourLinkedList.InsertLast(ourLinkedList,9);
ourLinkedList.InsertLast(ourLinkedList,6);
