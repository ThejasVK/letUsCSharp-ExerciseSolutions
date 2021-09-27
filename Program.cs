using System;

namespace chapter3_exercises_set2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
           //a           
           //we need 2 for loops 
           //first for loop for incrementing numbers from 1 to 300
           for(int number = 1; number <= 300; number++)
            {
                int prime = 0; // initialize prime = 0 inside first for loop so that each time it iterates through the first loop, prime is set to 0
                //second for loop to repeatedly divide number with 2 till (number -1)
                for (int div = 2; div < number; div++)
                {
                    if (number % div == 0)// if any number is divisible by an other number other than one and itself, it is not a prime number!
                    {
                        prime = 1;
                        break;
                    }
                        
                }
                if (prime == 0 && number!=1)
                    Console.WriteLine("{0} is a prime number", number);
            }
            */

            //--------------------------------------------------------------------

            /*
            //b
            //to fill entire screen with smiley face 
            char ch = (char)1; //converting the integer 1 to char and storing in a variable called ch

            for(int j=0; j <= 30; j++) //there are around 30 lines in my console or output screen
            {
                for (int i = 0; i < 150; i++) 
                    Console.Write(ch);
                Console.Write('\n');
            }
            */

            //--------------------------------------------------------------------

            /*
            //c
            double div=0, sum = 0;
            for (int i = 1; i <= 7; i++)
            {
                double fact = i;
                for (int number =i;number>1;number--)
                    fact = fact * (number -1);
                Console.WriteLine("Factorial of {0} is {1}",i,fact);
                div = i / fact;
                Console.WriteLine("i/fact of {0} is {1} is",i, div);
                sum += div;
            }
            Console.WriteLine("Sum of first seven terms of the expression is {0}", sum);
            */

            //--------------------------------------------------------------------

            /*
            //d
            //all combinations of 1,2,3
            int i, j, k;
            for (i = 1; i <= 3; i++)
            {
                for (j = 1; j <= 3; j++)
                {
                    for (k = 1; k <= 3; k++)
                    {
                        if (i != j && i != k && j != k)
                            Console.WriteLine("{0}{1}{2}", i, j, k);
                    }
                }
            }
            */

            //--------------------------------------------------------------------

            /*
            //e
            // calculating intelligence level of humans
            double i = 0, y, x;
            for (y = 1; y <= 6; y++)
            {
                for(x = 5.5; x <= 12.5; x += 0.5)
                {
                    i = 2 + (y + (0.5 * x));
                    Console.Write(i+"\t");
                }
                Console.WriteLine(" ");
            }
            */

            //--------------------------------------------------------------------

            /*
            //f
            //ASCII code of A = 65 and ASCII code of G = 71            
            for(int i = 0; i <= 6; i++) // for writing the letters 7 times in 7 lines
            {
                //print characters A to G 
                for (char ch = (char)65;  ch <= (char)(71-i); ch++)
                {
                    Console.Write(ch);
                }

                //add space between the letters
                for (int sp = 1; sp <= i * 2 - 1; sp++)
                    Console.Write(" ");

                //print characters G to A
                for (char ch2 = (char)(71-i); ch2 >= (char)65; ch2--)
                {
                    if (ch2 == 71) ; //as we don't want G to repeat in the first line!
                    else
                        Console.Write(ch2);
                }
                Console.WriteLine("");
            }
            */

            //--------------------------------------------------------------------

            /*
            //g
            int count = 1;
            for(int i = 1; i <= 4; i++)
            {
                //include space in the beginning
                for (int sp = 1; sp <= 4 - i; sp++)
                    Console.Write(" ");
               
                //write the numbers after space
                for (int number = 1; number <= i; number++)
                {
                    Console.Write("{0} ", count);
                    count++; // count is incremented and the new value is
                }

                Console.WriteLine(" ");
            }
            */

            //--------------------------------------------------------------------

            /*
            //h
            //pascals triangle
            for (int i = 1; i <=5; i++)
            {
                for(int sp=1;sp<=6-i;sp++)
                    Console.Write("*");
                                
                Console.Write("1");

                for (int sp2=1;sp2<=i;sp2++)
                    Console.Write("*");

                Console.Write("1");

                Console.WriteLine(" ");
            }
            */

            //--------------------------------------------------------------------

            /*
            //i
            int n, pdt, i;
            Console.WriteLine("Enter any number of your choice");
            n = Convert.ToInt32(Console.ReadLine());
            for (i= 1; i<= 10; i++)
            {
                pdt = n * i;
                Console.WriteLine(n + " * " + i +" = "+pdt);
            }
            */

            //--------------------------------------------------------------------

            /*
            //j
            int year=1, alternate, actual;
            int actualProfit = 1000, machineCost = 6000, salvageValue = 2000, alternateEarning = 120; //12 % of 1000=120
            while (true)
            {
                actual = (actualProfit * year); 
                year++;
            }
            */

            //--------------------------------------------------------------------

            /*
            //k
            int p, r, q, n, set = 0;            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Set "+ ++set);
                int pdt = 0, sum = 0;
                double a = 0, pow = 0;
                Console.WriteLine("Enter value of p,r,n and q");
                Console.Write("Enter principal amount : ");
                p = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the rate : ");
                r = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the time : ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the compound interest : ");
                q = Convert.ToInt32(Console.ReadLine());
                sum = 1 + (r / q);
                pdt = n * q;
                pow = Math.Pow(sum, pdt);
                a = p * pow;
                Console.WriteLine("Amount is " + a + " rs");
                Console.WriteLine(" ");            
            }
            */

            //--------------------------------------------------------------------

            /*
            //l
            double div = 0, x = 0, pow = 0;
            Console.WriteLine("Enter the value of x");
            x = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 7; i++)
            {
                if (i == 1)
                    x = (x - 1) / x;
                
                div = (x - 1) / x;
                x = x + 0.5 * (Math.Pow(div, i));
            }
            Console.WriteLine("The natural logarithm is {0} ",x);
            */

        }
    }
}
