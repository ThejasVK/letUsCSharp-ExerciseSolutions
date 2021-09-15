using System;

namespace Chapter2Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //[C] Attempt the following (Set 1 solutions)

            /*
            //a
            int cp, sp, profit;
            Console.WriteLine("Enter the cost price of the item");
            cp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the selling price of the item");
            sp = Convert.ToInt32(Console.ReadLine());
            profit = sp - cp;
            if (profit > 0)
            {
                Console.WriteLine("Seller made profit");
                Console.WriteLine("You had a profit of " + profit);
            }
            else
            {
                Console.WriteLine("Seller incurred loss ");
                Console.WriteLine("You incurred a loss of " + -profit);
            }
            */

            //-------------------------------------------------------------

            /*
            //b
            int n;
            Console.WriteLine("Enter any  integer");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}", n % 2 == 0 ? "Even" : "Odd");
            */

            //-------------------------------------------------------------

            /*
            //c
            //Conditions for leap year are : 1. The year is multiple of 400.
            //                               2. The year is multiple of 4 and not multiple of 100.
            //                               3. If divisible by 100 then not a leap year   
            int year;
            Console.WriteLine("Enter the year");
            year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0 || year % 4 == 0)
                Console.WriteLine(year + " is a Leap year");
            else if(year%100==0)
                Console.WriteLine(year + " is not a Leap year");
            else
                Console.WriteLine(year + " is not a Leap year");
            */

            //-------------------------------------------------------------

            /*
            //d
            //Gregorian Calendar Problem
            //basic year is chosen as the least year which user can enter through the keyboard where it should be Monday on 01th of January
            int year, basicYear=1901 , leapYear, remainingYear, totalDays, day;
            Console.WriteLine("Enter the year");
            year = Convert.ToInt32(Console.ReadLine());
            //Calculating total days between input year and basic year
            year = year - basicYear;
            //Calculating the leap year
            leapYear = year / 4 - year / 100 + year / 400;
            //Calculating years which are not leap years
            remainingYear = year - leapYear;
            //Calculatng total days present in the year
            totalDays = (remainingYear * 365) +(leapYear * 366) + 1;
            //Finding the actual day
            day = totalDays % 7;
            if (day == 0)
                Console.WriteLine("Monday");
            else if (day == 1)
                Console.WriteLine("Tuesday");
            else if (day == 2)
                Console.WriteLine("Wednesday");
            else if (day == 3)
                Console.WriteLine("Thursday");
            else if (day == 4)
                Console.WriteLine("Friday");
            else if (day == 5)
                Console.WriteLine("Saturday");
            else if (day == 6)
                Console.WriteLine("Sunday");
            else
                Console.WriteLine("Wrong Year Entered");
            */

            //-------------------------------------------------------------

            /*
            //e
            int n, a, b, c, d, e, rev;
            Console.WriteLine("Enter any 5 digit number");
            n = Convert.ToInt32(Console.ReadLine());
            a = (n % 10) * 10000;
            b = (n / 10 % 10) * 1000;
            c = (n / 100 % 10) * 100;
            d = (n / 1000 % 10) * 10;
            e = (n / 10000 % 10);
            rev = a + b + c + d + e;
            Console.WriteLine("Reversed number is " + rev);
            if (n == rev)
                Console.WriteLine("Original and the reversed numbers are equal");
            else
                Console.WriteLine("Original and the reversed numbers are NOT equal");
            */

            //-------------------------------------------------------------

            /*
            //f
            int ram, shyam, ajay;
            Console.WriteLine("Enter  ages of Ram, Shyam and Ajay");
            ram = Convert.ToInt32(Console.ReadLine());
            shyam = Convert.ToInt32(Console.ReadLine());
            ajay = Convert.ToInt32(Console.ReadLine());
            if (ram < ajay && ram < shyam)
                Console.WriteLine("Ram is the youngest");
            else if (shyam < ram && shyam < ajay)
                Console.WriteLine("Shyam is the youngest");
            else
                Console.WriteLine("Ajay is the youngest");
            */

            //-------------------------------------------------------------

            /*
            //g
            int angle1, angle2, angle3;
            Console.WriteLine("enter  3 angles of a triangle");
            angle1 = Convert.ToInt32(Console.ReadLine());
            angle2 = Convert.ToInt32(Console.ReadLine());
            angle3 = Convert.ToInt32(Console.ReadLine());
            if (angle1 + angle2 + angle3 == 180)
                Console.WriteLine("It is a trieangle");
            else
                Console.WriteLine("It is not a triangle");
            */

            //-------------------------------------------------------------


            /*
            //h
            int n;
            Console.WriteLine("Enter any number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Absolute of {0} is {1}", n ,Math.Abs(n));
            */

            //-------------------------------------------------------------

            /*
            //i
            int length, breadth, area, perimeter;
            Console.WriteLine("Enter the length and breadth of the rectangle");
            length = Convert.ToInt32(Console.ReadLine());
            breadth = Convert.ToInt32(Console.ReadLine());
            area = length * breadth;
            perimeter = 2 * length + breadth;
            if (area < perimeter)
                Console.WriteLine("Area is lesser than perimeter");
            else
                Console.WriteLine("Area is greater than perimeter");
            */

            //-------------------------------------------------------------

            //j

            //-------------------------------------------------------------

            //k

            //-------------------------------------------------------------
            //-------------------------------------------------------------
           
        }
    }
}
