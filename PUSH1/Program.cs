namespace PUSH1;

class Program
{
    static void Main(string[] args)
    {
        Stack<int> numbers = new Stack<int>();

        numbers.Push(10);
        numbers.Push(20);
        numbers.Push(30);
        numbers.Push(40);

        foreach (int item in numbers)
        { 
            Console.WriteLine(item);
            Console.ReadKey();
        }
        
    }
}
