using System;

namespace ArrayPointers
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int sizeOfArray = 7;

                int* ArrayOfFactorials = stackalloc int [sizeOfArray];

                int* pointer = ArrayOfFactorials;

                *pointer++ = 1;

                for (int i = 2; i <= sizeOfArray; pointer++,i++)
                {
                    *pointer = pointer[-1] * i;
                }
                pointer = ArrayOfFactorials;

                for (int i = 1; i <= sizeOfArray; pointer++,i++)
                {
                    Console.WriteLine(*pointer);
                }


            }
        }
    }
}
