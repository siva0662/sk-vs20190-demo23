using System;

namespace csharp_Demo
{
    class program
    {
        static void Main()
        {
            //    int sum = 0;
            //    int product = 0;
            //    //  int fn = 10;
            //    // int sn = 2;
            //    // sum = fn + sn;
            //    // product = fn * sn;
            //    calculate(10, 20, out sum, out product);
            //    Console.WriteLine("sum is:{0} and product is:{1} ",sum,product);
            //}
            //static void calculate( int fn,int sn,out int sum,out int product)
            //{
            //    sum = fn + sn;
            //    product = fn * sn;
            int num1 = 10;
            int num2 = 20;
            //int temp;
            //temp = num1;
            //num1 = num2;
            //num2 = temp;
            swap( ref num1,  ref num2);
            Console.WriteLine("num1 is:{0},num2 is:{1}", num1, num2);
        }
        static void swap(ref int x ,ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
    }
}
