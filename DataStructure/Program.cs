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
LinkedList<int> l= new LinkedList<int>();