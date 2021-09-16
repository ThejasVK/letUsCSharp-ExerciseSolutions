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
            /*
            //j
            //slope = y2 - y1 / x2 - x1
            //If slopes of both these points are equal, then all these 3 points lie on same straight line.
            int x1, y1, x2, y2, x3, y3, m, n;
            Console.WriteLine("Enter x and y coordinates of point 1");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter x and y coordinates of point 2");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter x and y coordinates of point 3");
            x3 = Convert.ToInt32(Console.ReadLine());
            y3 = Convert.ToInt32(Console.ReadLine());

            m = (y2 - y1) / (x2 - x1) ;
            n = (y3 - y2)  / (x3 - x2) ;
            
            if (m == n)
                Console.WriteLine("All 3 points fall on a straight line!");
            else
                Console.WriteLine("All 3 points do NOT fall on a straight line!");
            */

            //-------------------------------------------------------------

            /*
            //k
            //formula to find distance from point(x,y) to circle centre(cx,yx)
            //distance = sqrt(pow((x-cx),2) + pow((y-cy),2))
            int x, y, r, cx, cy;            
            double distance;//Because square root can be a decimal number
            Console.WriteLine("Enter the x and y coordinates of the point");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the x and y coordinates of the circle centre");
            cx = Convert.ToInt32(Console.ReadLine());
            cy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the radius of the circle");
            r = Convert.ToInt32(Console.ReadLine());

            distance = Math.Sqrt(Math.Pow(x - cx, 2) + Math.Pow(y - cy, 2));
            Console.WriteLine("Distance is "+ distance);

            if (distance > r)
                Console.WriteLine("Point lies outside the circle");
            else if (distance == r)
                Console.WriteLine("Point lies on the circle");
            else
                Console.WriteLine("Point lies inside the circle");
            */

            //-------------------------------------------------------------

            /*
            //l
            int x, y;
            Console.WriteLine("Enter the x and y coordinates of a point");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            if (x == 0 && y == 0)
                Console.WriteLine("Point lies on the origin");
            else if (y ==0 && x>0)
                Console.WriteLine("Point lies on x axis");
            else if (x==0&&y>0)
                Console.WriteLine("Point lies on y axis");
            else
                Console.WriteLine("Point lies somewhere else");
            */

            //-------------------------------------------------------------
            //-------------------------------------------------------------
            
        }
    }
}
