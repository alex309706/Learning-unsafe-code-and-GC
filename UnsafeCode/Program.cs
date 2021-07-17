using System;

namespace UnsafeCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
        }
        unsafe public static void Test()
        {
            int* x;
            int y = 10;
            x = &y;
            Console.WriteLine($"x* points at y. x* = {*x} y = {y}  ");

            y = 20;
            Console.WriteLine($"x* points at y. x* = {*x} y = {y}  ");

            *x = 50;

            Console.WriteLine($"x* points at y. x* = {*x} y = {y}  ");

            ulong address = (uint)*x;
            Console.WriteLine($"Address of x = {address}");




        }
    }
}
