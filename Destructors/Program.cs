using System;

namespace Destructors
{
    class Program
    {
        static void Test()
        {
            Person p = new Person();
        }
        static void Main(string[] args)
        {
            Test();
            GC.Collect();
            Console.ReadLine();


        }
    }
}
