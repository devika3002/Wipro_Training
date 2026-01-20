using System;
using  System.Collections.Generic;
namespace Demo_Collection_stack_queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(); //stack that can hold integer values
            //push some values onto the stack
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            //pop a value from the stack and display it
            int poppedValue = stack.Pop();
            Console.WriteLine("Popped Value:"+ poppedValue);
            //peek at the top value of the stack without removing it
            int topValue = stack.Peek();
            Console.WriteLine("Top Value:"+ topValue);
            //check if the stack contains a specific value
            bool contains20 = stack.Contains(20);
            Console.WriteLine("Stack contains 20:" + contains20);
            //Display the current count of items in the stack.
            int count = stack.Count;
            Console.WriteLine("Current Count:"+ count);
            //clear the stack
            stack.Clear();
            Console.WriteLine("Stack cleared.Count:"+ stack.Count);

        }
    }
}

