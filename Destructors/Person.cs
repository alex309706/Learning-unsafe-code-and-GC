using System;

namespace Destructors
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        ~Person()
        {
            Console.Beep();
            Console.WriteLine("Disposed!");
        }
    }
}