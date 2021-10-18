using System;

namespace Chapter5ExerciseSolutions_Set3
{
    class Program
    {
        static void Main(string[] args)
        {
            //[J] Attempt the following

            /*
            //a
            int number;
            Console.WriteLine("Enter a 5 digit positive number");
            number = Convert.ToInt32(Console.ReadLine());
            withoutRecursion(number);
            int ans = withRecursion(number);
            Console.WriteLine("Sum of 5 digit number with recursion is {0} ", ans);
        }

        static void withoutRecursion(int n)
        {
            int sum = 0;
            for (int i = 1; i <= 5; i++)
            {                
                sum = sum + n % 10;
                n = n / 10;                
            }
            Console.WriteLine("Sum of the 5 digits number without using recursion is {0} ", sum);
        }
        
        static int withRecursion(int n)
        {
            if (n == 0)
                return (0);
            else
            {
                return (n % 10 + withRecursion(n / 10));
            }
        }
        */

            //----------------------------------------------------------

            /*
            //b
            int number;
            Console.Write("Enter any positive number: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write("The prime factors with recursion are: ");
            primeFactors(number); //with recursion
            Console.WriteLine();
            Console.Write("The prime factors without recursion are: ");
            prime(number); //without recursion
            Console.WriteLine();
        }
            static void primeFactors(int n)
        {
            if(n==1)
                Console.Write(n);
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write(i + " ");
                    primeFactors(n / i);
                    break;
                }
            }
           
        }
        static void prime(int n)
        {
            if (n == 1)
                Console.Write(n);
            for (int count = 2;(n>1); count++)
            {
                while (n % count == 0)
                {
                    Console.Write(count + " ");
                    n = n / count;
                }
            }
        }
            */

            //----------------------------------------------------------

            /*
            //c
            //fibonaci sequence
            int c = 1;
            Console.WriteLine("The fibonacci series of the first 25 numbers are");
            for(int i = 1; i <= 25; i++)
            {
                Console.Write(fibonacci(c) + " ");
                c++;
            }
        }

        static int fibonacci(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return (fibonacci(n - 1) + fibonacci(n - 2));
        }
            */

            //----------------------------------------------------------

            /*
            //d
            int num;
            Console.WriteLine("Enter any number ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Binary equivalent is {0}", binary(num));
        }
            static int binary (int num)
            {
                if (num == 0)
                    return 0;
                else 
                    return ((num % 2) + (10 * binary(num / 2)));
            }
            */

            //----------------------------------------------------------

            /*
            //e
            int n=25;
            Console.WriteLine("Sum of first 25 natural numbers are {0}",sum(n));
        }
        static int sum (int n)
        {
            if (n != 0)
            {
                return (n + sum(n - 1));
            }
            else
                return 0;
            
        }
            */

            //----------------------------------------------------------

            /*
           //REPEAT IT 
            //f
            int x,count =0;
            double sum = 0;
            double ans = 0;
            Console.WriteLine("Enter the value of x");
            x = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 9; i+=2)
            {
                ans = sin(x,i,count,sum);
                count++;
            }
            Console.WriteLine("sin({0}) is {1}", x, ans);
        }
        public static double sin(int x,int i,int count,double sum)
        {
            double pow = Math.Pow(x, i);
            double div = pow / fact(x);
            if (count == 0)
            {
                sum = div - sin(x,i,count,sum);
                return sum;
            }
            else
            {
                sum = sum + div;
                count = 0;
                return sum;
            }                
        }
        
        public static double fact (int x)
        {
            int factorial = 1;
            for (int i = 1; i <= x; i++)
                factorial = factorial * i;
            return factorial;
        }
            */
            

            //----------------------------------------------------------

            /*
            //g
            int a, b, c;
            Console.WriteLine("Enter the values of a,b,c");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            rightShift(a, b, c);
        }
        static void rightShift(int x,int y, int z)
        {
            for (int i = 0; i < 3; i++)
            {
                int a = x;
                //Console.WriteLine("Testing a " + a);
                x = z;
                //Console.WriteLine("Testing x " + x);
                z = y;
                //Console.WriteLine("Testing z " + z);
                y = a;
                //Console.WriteLine("Testing y " + y);
                Console.WriteLine($"x = {x} y = {y} z = {z}");
            }
        }
            */

            //----------------------------------------------------------

        //} //delete/comment this brace as you'll use it int the above code
     }
}
