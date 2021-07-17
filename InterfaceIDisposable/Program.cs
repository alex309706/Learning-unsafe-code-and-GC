using System;

namespace InterfaceIDisposable
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
            Console.ReadLine();
        }
        static void Test()
        {
            Person p = null;
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
