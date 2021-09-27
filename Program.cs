using System;

namespace chapter4_ExerciseSolutions
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            //C 
            //Menu driven program
            int ch=0;
            while(true)
            {
                Console.WriteLine("Enter\n 1. For Finding factorial of a number\n 2. For finding if a number is prime or not\n " +
                    "3. For finding if a number is odd or even\n 4. To Exit");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        int n, fact=1;
                        Console.WriteLine("Enter any number");
                        n = Convert.ToInt32(Console.ReadLine());
                        int number = n;
                        for (number=n; number> 1; number--)
                            fact = fact * number;
                        Console.WriteLine("Factorial of {0} is {1}", n, fact);
                        break;

                    case 2:
                        int prime,count=0;
                        Console.WriteLine("Enter any number");
                        n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 2; i < n - 1; i++)
                        {
                            prime = n % i;
                            if (prime == 0)
                            {
                                count++;
                                break;
                            }
                        }
                        if (count == 0 && n != 1)
                            Console.WriteLine("{0} is a prime number", n);
                        else
                            Console.WriteLine("{0} is not a prime number", n);
                        break;

                    case 3:
                        Console.WriteLine("Enter any number");
                        n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(n % 2 == 0 ? "Even" : "Odd");
                        break;

                    case 4:
                        break;

                    default:
                        Console.WriteLine("Wrong Choice entered");
                        break;
                }
            } 
            */

            //--------------------------------------------------------------

            /*
            //D
            string ch;
            int fail;
            Console.WriteLine("Enter the class of the student");
            ch = Console.ReadLine();
            switch (ch)
            {
                case "first":
                case "First":
                    Console.WriteLine("How many subjects has the student failed in?");
                    fail = Convert.ToInt32(Console.ReadLine());
                    if (fail > 3)
                        Console.WriteLine("No grace marks");
                    else
                        Console.WriteLine("Student gets a grace of 5 marks in each subject"); 
                    break;

                case "second":
                case "Second":
                    Console.WriteLine("How many subjects has the student failed in?");
                    fail = Convert.ToInt32(Console.ReadLine());
                    if (fail > 2)
                        Console.WriteLine("No grace marks");
                    else
                        Console.WriteLine("Student gets a grace of 4 marks in each subject");
                    break;

                case "third":
                case "Third":
                    Console.WriteLine("How many subjects has the student failed in?");
                    fail = Convert.ToInt32(Console.ReadLine());
                    if (fail > 1)
                        Console.WriteLine("No grace marks");
                    else
                        Console.WriteLine("Student gets a grace of 5 marks in each subject");
                    break;
            }
            */

            //--------------------------------------------------------------
            //--------------------------------------------------------------
        }
    }
}
