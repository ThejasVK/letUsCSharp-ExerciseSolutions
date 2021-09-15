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
            Console.WriteLine("Your dearness allowance is Rs."+ dA + "\n");
            Console.WriteLine("Your house rent allowance is Rs."+hR+ "\n");
            total = dA + hR + bS;
            Console.WriteLine("Your gross monthly salary will be " + total+ "Rs");
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

            /*
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
            */
            
            /*----------------------------------------------------*/
            
            /*
            //i
            int n, f, l, sum;
            Console.WriteLine("Enter a four digit number");
            n = Convert.ToInt32(Console.ReadLine());
            f = (n / 1000) % 10;
            l = n % 10;
            Console.WriteLine("First digit is " + f + "\n" + "Last digit is " + l + "\n");
            sum = l + f;
            Console.WriteLine("Sum of first and last digit is " + sum);
            */

            /*----------------------------------------------------*/

            /*
            //j
            //total population = 80,000
            //men= 52% of population = 80,000*0.52 = 41,600
            //women = 48% of population = 80,000*0.48 = 38,400
            //total literacy = 48% of population = 80,000*0.48 = 38,400
            //thus, total illetracy = 80,000 - 38,400 = 41,600
            //literate men = 35% of pupolation = 80,000*0.35 = 28,000
            double men, women, literateMen, illiterateMen, literateWoman, illiterateWomen, totalLiteracy, totalIlletracy, population;
            population = 80000;
            men = 41600;
            women = 38400;
            totalLiteracy = 38400;
            totalIlletracy = 41600;
            literateMen = 28000;
            illiterateMen = totalLiteracy - literateMen;
            illiterateWomen = totalIlletracy - illiterateMen;
            Console.WriteLine("Percentage of illetrate men is " + illiterateMen / population * 100 + "\n" +
                "Percentage of illetrate women is " + illiterateWomen / population * 100 + "\n");
            Console.WriteLine("Total number of illetrate men is " + illiterateMen + "\n" +
                "Total number of illetrate woman is " + illiterateWomen + "\n");
            */

            /*----------------------------------------------------*/

            //k
            /*
            int amount,tens,fifties,hunreds;
            Console.WriteLine("Enter your amount in 100's");
            amount=Convert.ToInt32(Console.ReadLine());
            tens = amount / 10;
            fifties = amount / 50;
            hunreds = amount / 100;
            Console.WriteLine("You can get \n" + tens + " 10 rupee notes \n" + fifties + " fifty rupee notes\n" + hunreds + " hundred rupee notes");
            */

            /*----------------------------------------------------*/
            
            /*
            //l
            int sp_ofOneItem,total_sp, cp_ofOneItem, profit_OfoneItem, total_profit, items=15;
            Console.WriteLine("Enter the total Selling Price of 15 items");
            total_sp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the total profit earned");
            total_profit = Convert.ToInt32(Console.ReadLine());
            sp_ofOneItem = total_sp / items; //sp of one item
            profit_OfoneItem = total_profit / 15; //profit earned from one item
            cp_ofOneItem = sp_ofOneItem - profit_OfoneItem; //cost price of one item
            Console.WriteLine("The cost price of one item is " + cp_ofOneItem + " rupees");
            */
            
            /*----------------------------------------------------*/
            
            /*
            //m
            int n, a, b, c, d, e;
            Console.WriteLine("Ente a 5 digit number");
            n = Convert.ToInt32(Console.ReadLine());
            a = ((n / 10000) % 10) + 1; 
            b = ((n / 1000) % 10) + 1; 
            c = ((n / 100) % 10) + 1;
            d = ((n / 10) % 10) + 1;
            e = (n % 10) + 1;
            Console.WriteLine(a +""+ b+"" + c+"" + d+"" + e);
            */
        }
    }
}
