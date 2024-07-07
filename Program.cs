using MyQueue;
class Program{  //from another class
static void Main(string[] args){
MyQueueCls<string> obj= new MyQueueCls<string>(5);
MyQueueCls<int> obj2= new MyQueueCls<int>(5);

obj.Enqueue("Aydin");
obj.Enqueue("Salih");
obj.Enqueue("Beyza");
obj.Enqueue("Melis");
obj.Enqueue("Onat");
/*
Console.WriteLine(obj.Dequeue());
Console.WriteLine(obj.Dequeue());
Console.WriteLine(obj.Dequeue());
Console.WriteLine(obj.Dequeue());
Console.WriteLine(obj.Dequeue());   */
while(!obj.IsEmpty()){  //for dequeing obj
    System.Console.WriteLine(obj.Dequeue());
}System.Console.WriteLine();

obj2.Enqueue(1);
obj2.Enqueue(2);
//Console.WriteLine(obj2.Dequeue());
//Console.WriteLine(obj2.Dequeue());
while(!obj2.IsEmpty()){  //for dequeing obj
    System.Console.WriteLine(obj2.Dequeue());
}
}
}