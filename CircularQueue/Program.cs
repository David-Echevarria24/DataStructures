namespace CircularQueue;

class Program
{
    static void Main()
    {
        CircularQueue cq = new CircularQueue(5);
        cq.Enqueue(10);
        cq.Enqueue(20);
        cq.Enqueue(30);
        cq.Enqueue(40);
        cq.Display();
        Console.WriteLine("Dequeued: " + cq.Dequeue());
        cq.Display();
    }
 
 
}
 
class CircularQueue
{
    private int[] queue;
    private int front, rear, size;
 
    public CircularQueue(int capacity)
    {
        queue = new int[capacity];
        front = -1;
        rear = -1;
        size = capacity;
    }
 
    public void Enqueue(int value)
    {
        if ((rear + 1) % size == front)
        {
            Console.WriteLine("Queue overflow");
            return;
        }
        if (front == -1) front = 0;
        rear = (rear + 1) % size;
        queue[rear] = value;
    }
 
    public int Dequeue()
    {
        if (front == -1)
        {
            throw new InvalidOperationException("Queue underflow");
        }
        int value = queue[front];
        if (front == rear)
        {
            front = -1;
            rear = -1;
        }
        else front = (front + 1) % size;
        return value;
    }
 
    public void Display()
    {
        if (front == -1)
        {
            Console.WriteLine("Queue is empty");
            return;
        }
        int i = front;
        do
        {
            Console.Write(queue[i] + " ");
            i = (i + 1) % size;
        } while (i != (rear + 1) % size);
        Console.WriteLine();
    }
}
