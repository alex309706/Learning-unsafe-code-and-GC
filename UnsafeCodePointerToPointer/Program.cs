using System;

namespace UnsafeCodePointerToPointer
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int* x;
                int y = 10;
                x = &y;
                int** z = &x;

                Console.WriteLine($"X points at y. y = {y} *x={*x} ");
                Console.WriteLine($"z points at x that points to y. y = {y} *x={*x} **z={**z} ");

                *x = 500;
                Console.WriteLine("After change *x!");
                Console.WriteLine($"z points at x that points to y. y = {y} *x={*x} **z={**z} ");

                **z = 100;
                Console.WriteLine("After change **z!");
                Console.WriteLine($"z points at x that points to y. y = {y} *x={*x} **z={**z} ");

            }
        }
    }
}
