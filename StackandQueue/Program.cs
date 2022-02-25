using System;

namespace StackandQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Stack and Queue Programs");
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            linkedListStack.Display();
            linkedListStack.Peek();
            linkedListStack.Pop();
            linkedListStack.IsEmpty();
        }
    }
}