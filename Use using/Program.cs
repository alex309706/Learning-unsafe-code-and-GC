using System;

namespace Use_using
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start of main!");
            Test();
            Console.WriteLine();
            WholeMethodVisibility();
            Console.WriteLine("End Of Main!");
        }
        static void Test()
        {
            using(Person  p = new Person() { Name = "Alex"})
            {
                Console.WriteLine($"Person name : {p.Name}");
            }
            Console.WriteLine("End of Test method!");
        }
        static void WholeMethodVisibility()
        {
            using Person p = new Person() { Name= "Alex"};

            Console.WriteLine($"Person name : {p.Name}");

            Console.WriteLine("End of WholeMethodVisibility method!");

        }
    }
}
