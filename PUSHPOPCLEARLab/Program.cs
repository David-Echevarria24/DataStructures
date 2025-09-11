using System.Reflection.Metadata.Ecma335;

namespace PUSHPOPCLEARLab;

using System;

public class Program
{
    public static void Main()
    {
        IntStack stack = new IntStack(5);
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);

        stack.Display();

        Console.WriteLine("\nPop: " + stack.Pop());

        // Peek at top
        Console.WriteLine("Peek: " + stack.Peek());

        // Pop again
        Console.WriteLine("Pop: " + stack.Pop());

        // Display updated stack
        Console.WriteLine();
        stack.Display();
    }
}


public class IntStack
{
    private int[] stackArray;
    private int top;
    private int maxSize;

    // Constructor to initialize the stack
    public IntStack(int size)
    {
        maxSize = size;
        stackArray = new int[maxSize];
        top = -1; // Indicates an empty stack
    }

    // Push method with overflow check
    public void Push(int value)
    {
        if (top >= maxSize - 1)
        {
            Console.WriteLine("Stack Overflow: Cannot push " + value);
            return;
        }
        stackArray[top++] = value;
    }

    // Pop method with underflow check
    public int Pop()
    {
        if (top < 0)
        {
            Console.WriteLine("Stack Underflow: Cannot pop");
            return -1; // Sentinel value for error
        }
        return stackArray[top--];
    }

    // Peek method to view top element
    public int Peek()
    {
        if (top < 0)
        {
            Console.WriteLine("Stack is empty: Cannot peek");
            
        }
        return stackArray[top];
    }

    // Display stack contents from top to bottom
    public void Display()
    {
        if (top < 0)
        {
            Console.WriteLine("Stack is empty.");
            return;
        }

        Console.WriteLine("Stack contents (top to bottom):");
        for (int i = top; i >= 0; i--)
        {
            Console.WriteLine(stackArray[i]);
        }
    }
}