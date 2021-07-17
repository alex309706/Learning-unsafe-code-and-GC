using System;

namespace Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
            GC.Collect();
            Console.ReadLine();
        }
        static void Test()
        {
            Person p =null;
            try
            {
                p = new Person();
            }
            finally
            {
                if (p!=null)
                {
                    p.Dispose();
                }
            }
        }
    }
}
