using MemoryList;
using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMemoryList<int> list = new MyMemoryList<int>();
            list.Add(10);
            Console.WriteLine("testing");
        }
    }
}
