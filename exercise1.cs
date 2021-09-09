using System;

namespace chapter1Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //a
            double bS,dA, hR; ;
            Console.WriteLine("Enter your basic salary");
            bS = Convert.ToInt32(Console.ReadLine());
            dA = 0.04 * bS;
            hR = 0.02 * bS;
            Console.WriteLine("Your dearness allowance is Rs."+ dA);
            Console.WriteLine("Your house rent allowance is Rs."+hR);
            */

            /*----------------------------------------------------*/

            /*
            //b
            double dist,m,feet,cm,inch;
            Console.WriteLine("Enter distance between any 2 cities in Kilometers.");
            dist = Convert.ToDouble(Console.ReadLine());
            m = dist * 1000;
            feet = dist * 3280.10;
            inch = dist * 39370.079;
            cm = dist * 100000;
            Console.WriteLine("\nThe distance in meters is " + m + "meters\n" + "The distance in centimeters is "+ cm +"centimeters\n"+
                "The distance in inches is "+ inch+ "inches\n"+ "The distance in feet is "+ feet+"feet");
            */

            /*----------------------------------------------------*/

            /*
            //c
            int sub1, sub2, sub3, sub4, sub5, aggregate, percentage;
            Console.WriteLine("Enter marks obtained in 5 subjects");
            sub1 = Convert.ToInt32(Console.ReadLine());
            sub2 = Convert.ToInt32(Console.ReadLine());
            sub3 = Convert.ToInt32(Console.ReadLine());
            sub4 = Convert.ToInt32(Console.ReadLine());
            sub5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You got \n" + sub1 + "\n" + sub2 + "\n" + sub3 +"\n" + sub4 + "\n" + sub5 + "\n");
            aggregate = sub1 + sub2 + sub3 + sub4 + sub5;
            percentage = (aggregate / 500)*100;
            Console.WriteLine("Your aggregate is " + aggregate + "\n" + "Your percentage is " + percentage);
            */

            /*----------------------------------------------------*/

            /*
            //d
            float tempInCelcius, tempInFahrenheit;
            Console.WriteLine("Enter temperature of your city in Fahrenheit");
            tempInFahrenheit = Convert.ToSingle(Console.ReadLine());
            tempInCelcius = (tempInFahrenheit - 32) * (5 / 9);
            Console.WriteLine("Temperature of the city is " + tempInCelcius + " degree celcius");
            */

            /*----------------------------------------------------*/

            /*
            //e
            int l, b, r, areaOfRectangle, perimeterOfRectangle;
            double areaOfCircle, circumfarenceOfCircle;
            double pi = 3.14;
            Console.WriteLine("Enter length & breadth of the rectangle and radius of the circle");
            l = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            r = Convert.ToInt32(Console.ReadLine());
            areaOfRectangle = l * b;
            perimeterOfRectangle = 2 *( l + b);
            areaOfCircle = pi * r *r;
            circumfarenceOfCircle = 2 * pi * r;
            Console.WriteLine("Area of the rectangle is " + areaOfRectangle + " meter square\n" + "Perimeter of the rectangle is " +
                perimeterOfRectangle + " meters\n" + "Area of the circle is " + areaOfCircle + " meter square\n" + 
                "Circumferance of the circle is " + circumfarenceOfCircle + " meters");
            */

            /*----------------------------------------------------*/

            /*
            //f
            int c, d,e;
            Console.WriteLine("Enter any 2 numbers");
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            e = c;
            c = d;
            d = e;
            Console.WriteLine("Values  are now intrchanged value  of C = " +
                c + " and D = " + d);
            */

            /*----------------------------------------------------*/

            /*
            //g
            int n,sum=0;
            Console.WriteLine("Enter a 5 digit number");
            n = Convert.ToInt32(Console.ReadLine());
            sum = n % 10 + (n / 10) % 10 + (n / 100) % 10 + (n / 1000) % 10 + (n / 10000) % 10 + (n / 100000) % 10;
            Console.WriteLine("Sum of their digits are " + sum);
            */

            /*----------------------------------------------------*/

            //h
            int n, a, b, c, d, e;
            Console.WriteLine("Ente a 5 digit number");
            n = Convert.ToInt32(Console.ReadLine());
            a = n % 10;
            b = (n / 10) % 10;
            c = (n / 100) % 10;
            d = (n / 1000) % 10;
            e = (n / 10000) % 10;
            Console.WriteLine("Reversed digits are " + a+b+c+d+e);

        }
    }
}
