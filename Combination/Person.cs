using System;

namespace Combination
{
    class Person:IDisposable
    {
        bool disposed = false;

        public int Age { get; set; }
        public string Name { get; set; }
        ~Person()
        {
            Dispose(false);
        }

        public void Dispose()
        {

            Dispose(true);

            GC.SuppressFinalize(this);
        }
        public void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    //release resources
                    Console.Beep();
                    Console.WriteLine("Disposed!");
                }
            }
        }
    }
}
