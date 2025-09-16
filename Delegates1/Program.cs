namespace Delegates1;

// Define a delegate that takes two int parameters and returns an int
public delegate int Calculator(int a, int b);
class Program
{
    // Methods matching the delegate signature
    static void Greet(string name) => Console.WriteLine($"Hello, {name}");
    static void Farewell(string name) => Console.WriteLine($"Goodbye, {name}");
   
    static void Main(string[] args)
    {
        Console.Write("Enter operation (greet or farewell): ");
        string input = Console.ReadLine();
        // Switch expression returns the delegate directly
        Action<string> action = input switch
        {
            "greet" => Greet,
            "farewell" => Farewell,
            
            _ => throw new InvalidOperationException("Invalid operation.")
        };
        // Call the selected method through the delegate
        action("Alice");
    }
}