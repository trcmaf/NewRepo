using System;
using System.Threading;

namespace practicum_03_upr1
{
    class Program
    {
        static void Main(string[] args)
        {
            WaitCallback callback = new WaitCallback(ShowMyText);
            ThreadPool.QueueUserWorkItem(callback, "Hello");
            ThreadPool.QueueUserWorkItem(callback, "Hi");
            ThreadPool.QueueUserWorkItem(callback, "Heya");
            ThreadPool.QueueUserWorkItem(callback, "Goodbye");
            Console.Read();
        }
        static void ShowMyText(object state)
        {
            string myText = (string)state;
            Console.WriteLine(ThreadPool: (0) - (1), Thread.CurrentThread.ManagedThreadId, myText);
        }
    }
}

