 
using System.Collections;
 
class Program
{
    static void Main()
    {
        Queue<string> queueNames = new Queue<string>();
 
        queueNames.Enqueue("Apple");
        queueNames.Enqueue("Mango");
        queueNames.Enqueue("Banana");
 
        Console.WriteLine("Number of elements in the queue: {0}", queueNames.Count);
 
        Console.WriteLine("The first element in the queue was: ");
        Console.WriteLine(queueNames.Dequeue());
 
        Console.WriteLine("Number of elements in the queue: {0}", queueNames.Count);
 
        Console.WriteLine(queueNames.Contains("Apple"));
        Console.WriteLine(queueNames.Contains("Peach"));
 
        Console.WriteLine(queueNames.Peek());
 
    }
}
 