using System;

namespace csharp_Employee
{
    public delegate void calculator(int a,int b);
    class program
    {
        static void Main()
        {
            //  AddDelgate del = (x, y) => x + y;
            // Console.WriteLine(del(10, 20));
            calculator c = Addition;
            c += Substraction;
            c += Multiply;

            c(10, 20);
           
        }
        static void Addition (int a, int b)
        { Console.WriteLine($"Addition:{a + b}"); }

        static void Substraction (int a,int b)
        { Console.WriteLine($"Substraction:{a - b}"); }

            static void Multiply(int a, int b)
            { Console.WriteLine($"Multiply:{a * b}"); }
        }

}