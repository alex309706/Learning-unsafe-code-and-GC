using System;

namespace KeywordFixed
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello,Alex!";
            int[] arrayOfIntegeres = new int[] {1,2,3,4,5 };

            unsafe
            {
                fixed(int* pointerToInt = arrayOfIntegeres)
                {
                    int third = *(pointerToInt+2);
                    Console.WriteLine(third);
                }

                fixed(char* pointerToString = hello)
                {
                    char comma = *(pointerToString+5);
                    Console.WriteLine(comma);
                }
            }

        }
    }
}
