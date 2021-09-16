using System;

namespace Set3_SubHeading_K__
{
    class Program
    {
        static void Main(string[] args)
        {
            //[J] Rewrite using Conditional operators

            /*
            //a
            int x, max, min,op;
            Console.WriteLine("Enter max");
            max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            x = Convert.ToInt32(Console.ReadLine());
            op = x > max ? max = x : min = x;
            */

            //-----------------------------------------------------

            /*
            //b
            int code;
            code = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((code >1 ? "Jarusalem" : (code < 1 ? "Eddie": "C# Brain")));
            */

            //-----------------------------------------------------

            /*
            //c
            float sal;
            Console.WriteLine("Enter Salary");
            sal = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine((sal < 40000 && sal > 25000) ? "Manager" : ((sal < 25000 && sal > 15000) ? "Accountant" : "Clerk"));
            */


            //-----------------------------------------------------
            //-----------------------------------------------------

            //[K] Attempt the follwing

            //a
            //1

            //2


            //-----------------------------------------------------

            /*
            //b
            int year;
            Console.WriteLine("Enter the year");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((year % 4 == 0 && year % 100 != 0) || year%400 == 0 ? "Leap Year" : "Not a leap year");
            */

            //-----------------------------------------------------

            /*
            //c
            int a, b, c;
            Console.WriteLine("Enter any 3 integers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((a > b && a > c) ? "A is greatest" : (b > c && b > a) ? "B is greatest" : "C is greatest");
            */

            //-----------------------------------------------------

            /*
            //e
            int a = 1, b = 2, c = 0;
            c = a < b ? a : 0;
            */

            //-----------------------------------------------------
            //-----------------------------------------------------
                       
        }
    }
}
