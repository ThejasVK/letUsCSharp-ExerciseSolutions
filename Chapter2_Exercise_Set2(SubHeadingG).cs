using System;

namespace Chapter2ExerciseSet2_SubHeadingG_
{
    class Program
    {
        static void Main(string[] args)
        {
            //[G] Attempt the following (Set 2 solutions)

            /*
            //a
            int year;
            Console.WriteLine("Enter any year");
            year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                Console.WriteLine("Entered year is a leap year");
            else
                Console.WriteLine("Entered year is NOT a leap year");
            */

            //-------------------------------------------------------------

             /*
            //b
            char character;
            int AsciCode;
            Console.WriteLine("Enter a character");
            character = Convert.ToChar(Console.ReadLine());
            AsciCode = (int)character;
            Console.WriteLine("The AsciCode is " + AsciCode);
            if (AsciCode >= 65 && AsciCode <= 90)
                Console.WriteLine("You entered a capital letter");
            else if (AsciCode >= 97 && AsciCode <= 122)
                Console.WriteLine("You entered a small case letter");
            else if (AsciCode >= 48 && AsciCode <= 57)
                Console.WriteLine("You entered a number");
            else if ((AsciCode >= 0 && AsciCode <= 47) || (AsciCode >= 58 && AsciCode <= 67) || (AsciCode >= 91 && AsciCode <= 96) || (AsciCode >= 123 && AsciCode <= 127))
                Console.WriteLine("You entered a special character!");
            else
                Console.WriteLine("Wrong value entered try again!");
            */

            //-------------------------------------------------------------

            /*
            //c
            float hardness, Ccontent, Tstrength;
            Console.WriteLine("Enter the hardnes, Carbon content and the Tensile strength of the steel");
            hardness = Convert.ToSingle(Console.ReadLine());
            Ccontent = Convert.ToSingle(Console.ReadLine());
            Tstrength = Convert.ToSingle(Console.ReadLine());
            if (hardness > 50 && Ccontent < 0.7 && Tstrength > 5600)
                Console.WriteLine("Grade of steel is 10");
            else if (hardness > 50 && Ccontent < 0.7)
                Console.WriteLine("Grade of steel is 9");
            else if (Ccontent < 0.7 && Tstrength > 5600)
                Console.WriteLine("Grade of steel is 8");
            else if (hardness > 50 && Tstrength > 5600)
                Console.WriteLine("Grade of steel is 7");
            else if (hardness > 50 || Ccontent < 0.7 || Tstrength > 5600)
                Console.WriteLine("Grade of steel is 6");
            else
                Console.WriteLine("Grade of steel is 5");
            */

            //-------------------------------------------------------------

            /*
            //d
            int days;
            Console.WriteLine("Enter the number of days you're late to return the book");
            days = Convert.ToInt32(Console.ReadLine());
            if (days <= 5)
                Console.WriteLine("Pay a fine of 50 paisa");
            else if (days > 5 && days <= 10)
                Console.WriteLine("Pay a fine of 1 rupee");
            else if (days > 10 && days <= 30)
                Console.WriteLine("Pay a fine of 5 rupees");
            else
                Console.WriteLine("You're membership is cancelled ");
            */

            //-------------------------------------------------------------

            /*
            //e
            int a, b, c;
            Console.WriteLine("Enter 3 sides of the triangle");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if (a + b > c && b + c > a && a + c > b)
                Console.WriteLine("It is a valid triangle");
            else
                Console.WriteLine("It is NOT a valid triangle");
            */

            //-------------------------------------------------------------

            /*
            //f
            int a, b, c;
            Console.WriteLine("Enter 3 sides of the triangle");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if (a + b > c && b + c > a && a + c > b)
            {
                if (a == b && b == c && c == a)
                    Console.WriteLine("It is an equilateral triangle");
                else if (a == b || a == c || b == c)
                    Console.WriteLine("It is an isoscelese triangle");
                else //(a!=b && a!=c &&b!=c)
                    Console.WriteLine("It is a scalene triangle");
            }
            else
                Console.WriteLine("Try again it is NOT a valid triangle");
            */

            //-------------------------------------------------------------

            /*
            //g
            int time;
            Console.WriteLine("Enter the time taken by a worker in hours");
            time = Convert.ToInt32(Console.ReadLine());
            if (time >= 2 && time < 3)
                Console.WriteLine("Worker is highly effecient");
            else if (time >= 3 && time < 4)
                Console.WriteLine("Order the worker to improve his speed");
            else if (time >= 4 && time <= 5)
                Console.WriteLine("Give him training NOW!");
            else if (time > 5)
                Console.WriteLine("Time to say Goodbye..");
            else
                Console.WriteLine("Enter a valid input");
            */

            //-------------------------------------------------------------

            /*
            //h
            int credit, stock = 1000, order, supply;
            Console.WriteLine("Enter order quantity and credits");
            order = Convert.ToInt32(Console.ReadLine());
            credit = Convert.ToInt32(Console.ReadLine());
            if (order <= stock && credit >= 10)
                Console.WriteLine("Your order is supplied");
            else if (credit < 10)
                Console.WriteLine("Your credits are less");
            else if (credit >= 10 && stock < order)
            {
                supply = order - stock;
                Console.WriteLine("You'll be supplied {0} items, remaining {1} items will be sent within 12 working days", stock,supply);
            }
            */

            //-------------------------------------------------------------
        }
    }
}
