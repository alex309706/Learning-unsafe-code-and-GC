using System;

namespace InterfaceIDisposable
{
    class Person:IDisposable
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public void Dispose()
        {
            Console.Beep();
            Console.WriteLine("Disposed!");
        }
    }
}
