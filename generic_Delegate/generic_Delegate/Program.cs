using System;

namespace generic_Delegate
{
    public delegate T AddDelegate<T>(T arg1,T arg2);
    class Program
    {
        static void Main()
        {
            int a = 10;
            int b = 20;

            AddDelegate<int> del = add;
            Console.WriteLine(del(10,20));

            AddDelegate<double> del2 = sub;
            Console.WriteLine(del2(1.2, 1.5));
        }
        static int add(int x, int y) => x + y;
        static double sub(double x, double y) => x - y; 
    }
}
