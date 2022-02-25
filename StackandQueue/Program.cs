using System;

namespace StackandQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Stack and Queue Programs");
            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(70);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(56);
            linkedListQueue.Display();
            //linkedListStack.Peek();
            //linkedListStack.Pop();
            //linkedListStack.IsEmpty();
        }
    }
}