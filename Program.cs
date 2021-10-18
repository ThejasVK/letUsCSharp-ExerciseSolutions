using System;

namespace Chapter5_Set2
{
    class Program
    {
        static void Main(string[] args)
        {

            //[F] Answer the following 

            //-----------------------------------------------------

            /*
            //a
            //product of int and float
            int a;
            float b;
            Console.WriteLine("Enter any 2 numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Single.Parse(Console.ReadLine());
            float pdt = product(a, b);
            Console.WriteLine("The product of {0} and {1} is {2}", a, b, pdt);
        } //Closing the main functin

        static float product(int first,float second)
        {
            float answer = first * second;
            return (answer);
        }
        */

            //-----------------------------------------------------

            /*
            //b
            int a, b, c, d, e;
            Console.WriteLine("Enter any 5 integers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            e = Convert.ToInt32(Console.ReadLine());
            sumAvgStdDev(a, b, c, d, e, out int sum,out int avg, out double stdDev);
            Console.WriteLine("sum= {0}\navg= {1}\nstandard deviation= {2}\n", sum, avg, stdDev);
        }// closing the main function
        static void sumAvgStdDev(int v,int w,int x,int y,int  z, out int sum, out int avg, out double stdDev)
        {
            sum = v + w + x + y + z;
            avg = sum / 5;
            stdDev = standardDeviation(v,w,x,y,z,avg);
        }
        static double standardDeviation(int a, int b, int c, int d, int e, int avg)
        {
            double sumOfTerms,standard_deviation;
            float div = 1 / 5;
            double s = 1.0 / 5.0;
            Console.WriteLine(div);
            Console.WriteLine(s);
            double sumOfTerms1 = Math.Pow((a - avg),2);
            double sumOfTerms2 = Math.Pow((b - avg),2);
            double sumOfTerms3 = Math.Pow((c - avg),2);
            double sumOfTerms4 = Math.Pow((d - avg),2);
            double sumOfTerms5 = Math.Pow((e - avg),2);
            sumOfTerms = sumOfTerms1 + sumOfTerms2 + sumOfTerms3 + sumOfTerms4 + sumOfTerms5;
            Console.WriteLine("Testing: " + sumOfTerms);
            standard_deviation = Math.Sqrt(0.2 * sumOfTerms);
            Console.WriteLine("Testing: " + standard_deviation);
            return (standard_deviation);
        }
            */

            //-----------------------------------------------------

            /*
            //c
            //students marks
            int marks1, marks2, marks3;
            Console.WriteLine("Enter marks of the student in 3 subjects");
            marks1 = Convert.ToInt32(Console.ReadLine());
            marks2 = Convert.ToInt32(Console.ReadLine());
            marks3 = Convert.ToInt32(Console.ReadLine());
            result(marks1, marks2, marks3, out int average, out double percentage);
            Console.WriteLine("Average is {0} and the percentage is {1} %", average, percentage);
        }
        static void result (int a,int b,int c, out int avg, out double per)
        {
            int sum;
            //per = 0.0;
            sum = a + b + c;
            avg= sum / 3;
            per = ((double)sum/300) * 100; // need to convert sum to double otherwise output will be 0
        }
        */

        //-----------------------------------------------------
        
        } // delete/comment this bracket as we're closing it above 
    }
}
