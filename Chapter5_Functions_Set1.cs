using System;

namespace Chapter5ExerciseSolution
{
    class Program
    {
        static void Main(string[] args)
        { //scroll to the end and comment the closing brace of the main program. (these are functions)
            /*
            //[D] Answer the following


            //a
            //factporial
            int fact = 0, number;
            Console.Write("Enter any number : ");
            number = Convert.ToInt32(Console.ReadLine());
            fact = factorial(number);
            Console.WriteLine("Factoril of {0} = {1}", number, fact);
        } // closing the main function

            static int factorial (int n)
            {
                if (n == 1)
                {
                    return 1;
                }
                else
                {
                    return (n * factorial(n - 1));
                }
            }
            */

            //------------------------------------------

            /*
            //b
            int a, b;
            Console.WriteLine("Enter the values of a and b");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            double pow = power(a, b);
            Console.WriteLine("{0} raised to the power {1} is {2}", a, b, pow);
        } // closing main function

        static double power(int x,int y)
        {
            double ans;
            ans = Math.Pow(x, y);
            return (ans);
        }
            */

            //------------------------------------------------------------------

            /*
            //c
            // convert year entered into its roman equivalent
            int year;
            Console.Write("Enter any year ");
            year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Roman equivalent of " + year + " is: ");
            roman(year);
        }//closing main function

        static void roman(int enteredYear)
        {
            if (enteredYear >= 1000)
            {
                Console.Write("m");
                roman(enteredYear - 1000);
            }
            else if (enteredYear >= 500)
            {
                Console.Write("d");
                roman(enteredYear - 500);
            }
            else if (enteredYear >= 100)
            {
                Console.Write("c");
                roman(enteredYear - 100);
            }
            else if (enteredYear >= 50)
            {
                Console.Write("d");
                roman(enteredYear - 50);
            }
            else if (enteredYear >= 10)
            {
                Console.Write("x");
                roman(enteredYear - 10);
            }
            else if (enteredYear == 9)
            {
                Console.Write("ix");
                roman(enteredYear - 9);
            }
            else if (enteredYear >= 5)
            {
                Console.Write("v");
                roman(enteredYear - 5);
            }
            else if (enteredYear == 4)
            {
                Console.Write("iv");
                roman(enteredYear - 4);
            }
            else if (enteredYear >= 1)
            {
                Console.Write("i");
                roman(enteredYear - 1);
            }                        
        }
        */

            //------------------------------------------

            /*
            //d
            //leap year using functions
            int year;
            Console.Write("Enter any year: ");
            year = Convert.ToInt32(Console.ReadLine());
            leapYear(year);
        }//closing main function
    
        static void leapYear(int enteredYear)
        {
            Console.WriteLine(((enteredYear % 4 == 0 && enteredYear % 100 != 0) || enteredYear % 400 == 0) ? enteredYear+  "{0} is a leap year": "{1} is not a leap year", enteredYear);
        }
        */

            //------------------------------------------

            /*
            //e
            //prime factors of any number
            int n;
            Console.Write("Enter any number: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Prime factors of the numbers are: ");
            primeFactor(n);
        } //closing main function

        static void primeFactor(int number)
        {
            for (int count = 2;count<=number;count++)
            {
                if (number % count == 0)
                {
                    Console.Write(count + " ");
                    primeFactor(number / count);
                    break;
                }
            }
        }
        */
    
        } //delete/comment this while executing the code

    }
}
