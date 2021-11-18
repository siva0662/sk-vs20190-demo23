using System;

namespace benefice
{
    class Employee
    {
        //int eno;
        //string ename;
        //double esal;
        public int Eno {get;set;}
            public string Ename { get; set; }
    public double Esal { get; set; }

        public override string ToString()
        {
            return $"{Eno}\t{Ename}\t{Esal}";
        }
    }
class program
    {
        static void Main()
        {
            Employee employee = new Employee { Eno = 1001, Ename = "krishna", Esal = 96000 };
            Console.WriteLine(employee);

           // int a = 10;
           // Console.WriteLine(a);
        }
    }
}