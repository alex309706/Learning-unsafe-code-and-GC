using System;

namespace StructPointers
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                Student s; ;
                s.Age = 20;
                s.Height = 180;
                Console.WriteLine($"Age before graduation = {s.Age}");
                Console.WriteLine($"Height before graduation = {s.Height}");



                Student* studentPointer = &s;
                //changing value by pointer
                studentPointer->Age = 24;

                Console.WriteLine($"Pointer points to  {studentPointer->Age}");

                Console.WriteLine($"Age after graduation = {s.Age}");

                (*studentPointer).Height = 190;
                Console.WriteLine($"Height after changing = {s.Height}");

                Console.WriteLine($"Pointer of Height after changing = {studentPointer->Height}");
            }
        }
    }
    public struct Student
    {
        public int Age;
        public double Height;
    }
}
