using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace practicum_01_upr1
{
  class Program
  {
    static void Main(string[] args)
    {
        ThreadStart starter = new ThreadStart(Counting);
        Thread first = new Thread(starter);
        Thread second = new Thread(starter);
        first.Start(); 
        second.Start();
        first.Join(); 
        second.Join();
        Console.Read();
    }
    static void Counting()
    {
        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Count: {0} - Thread' { 1} ", 1, Thread.CurrentThread, ManagedThreadld);
            Thread.Sleep(10);
        }
    }
  }
}
