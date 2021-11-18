using System;

namespace csharp_sumproduct
{
    class Program
    {
        static void Main()
        {
            int sum = 0;
            int product = 0;

            Calculate(10, 20, out sum, out product);
            Console.WriteLine("Sum is: {0}, and Product is: {1}", sum, product);
        }

        static void Calculate(int FN, int SN, out int Sum, out int Product)
        {
            Sum = FN + SN;
            Product = FN * SN;
        }
    }
}
