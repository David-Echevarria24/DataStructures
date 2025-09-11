namespace PriorityQueue1;

class Program
{
    static void Main(string[] args)
    {
        PriorityQueue<string, int> queue = new PriorityQueue<string, int>();
        queue.Enqueue("Java", 50);
        queue.Enqueue("Python", 45);
        queue.Enqueue("JavaScript", 70);
        queue.Enqueue("C#", 1);
 
        while (queue.TryDequeue(out string item, out int priority))
        {
            Console.WriteLine($"The priority of the programming language {item} is {priority} ");
        }
    }
}
 