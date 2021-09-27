using System;

namespace chapter3_exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            //[B] Attempt the following

            /*
            //a
            int minTime= 40, totalTime, overtime, overtimePayment=0;
            int employee = 0;
            while (employee < 10)
            {
                Console.WriteLine("Enter number of hours employee " + ++employee + " has worked ");
                totalTime = Convert.ToInt32(Console.ReadLine());
                if (totalTime > minTime)
                {
                    overtime = totalTime - minTime;
                    overtimePayment = overtimePayment + (overtime * 12);
                }
            }
            Console.WriteLine("Total overtime pay is " + overtimePayment + " Rs");
            */

            //--------------------------------------------------------

            /*
            //b
            int n, number,factorial=1 , i=0;
            Console.WriteLine("Enter any integer below 30");
            n = Convert.ToInt32(Console.ReadLine());
            number = n;
            while (i<n)
            {
                factorial = factorial * number--;
                i++;
                //Console.WriteLine(n+"!" + " = " + number + " * " + factorial);
            }
            Console.WriteLine("Factorial of " + n + " is " + factorial);
            */

            //--------------------------------------------------------

            /*
            //c
            int number, power, ans=1;            
            Console.WriteLine("Enter any 2 numbers");
            number = Convert.ToInt32(Console.ReadLine());
            power = Convert.ToInt32(Console.ReadLine());                        
            int i = 1;
            while (i <=power)
            {
                ans = ans * number;
                i++;
                //Console.WriteLine("answer IS "+ ans); can use this line for error solving or debugging
            }
            Console.WriteLine(number + " raised to the power " + power + " is " + ans);
            */

            //--------------------------------------------------------

            /*
            //d
            //int 
            int asciiCode = 0;
            while (asciiCode <= 255)
            {
                char character= Convert.ToChar(asciiCode);                
                Console.WriteLine("The ASCII value of character " + character + " is " + asciiCode);
                asciiCode++;
            }
            */

            //--------------------------------------------------------

            /*
            //e
            //Armstrong Number Problem
            int originalNumber = 1, number;

            while(originalNumber<=500)
            {   
                //initialize inside the loop so that it resets everytime to 0 
                double sum = 0;
                int remainder = 0;
                number = originalNumber;
                //loop until number is lesser than 0
                while (number>0)
                {
                    remainder = number % 10; //obtaining each digit of the number                    
                    sum += Math.Pow(remainder, 3); // store the sum of the power of individual digits in sum                    
                    number /= 10; //dividing the number by 10 (number= number / 10) 
                }
                // if originalNumber is equal to sum, then it is an Armstrong number
                if (originalNumber == sum)
                    Console.WriteLine("{0} is an Armstrong number", sum);
                
                originalNumber++;
            }
            */

            //--------------------------------------------------------

            /*
            //f
            //main objeive is for the system to win
            int matchsticks = 21, userChoice=0, systemChoice=0;
            while (matchsticks >= 1)
            {               
                Console.WriteLine("There are {0} matchsticks remaining", matchsticks);
                Console.WriteLine("Pick any number of matchsticks between 1 to 4");
                userChoice = Convert.ToInt32(Console.ReadLine());
                if (userChoice > 4 || userChoice < 1)
                {
                    Console.WriteLine("Wrong choice entered");
                    continue;
                }               
                systemChoice = 5 - userChoice; //at most, there can only be 5 combinations of user choices till the game ends
                Console.WriteLine("System picks {0} matchsticks", systemChoice);
                matchsticks = matchsticks - userChoice - systemChoice;

                if (matchsticks == 1)
                {
                    Console.WriteLine("System wins ");
                    break;
                }
            }
            */

            //--------------------------------------------------------

            /*
            //g
            int userNumber,positiveNumber=0,negativeNumber=0,zero=0,choice;
            do
            {
                Console.Write("Enter any integer : ");
                userNumber = Convert.ToInt32(Console.ReadLine());
                if (userNumber > 0)
                    positiveNumber++;
                else if (userNumber < 0)
                    negativeNumber++;
                else if (userNumber == 0)
                    zero++;

                Console.WriteLine("Do you want to Continue?(y/n)");
                choice = Convert.ToChar(Console.ReadLine());
            } while (choice == 'y' || choice == 'Y');
            Console.WriteLine("You entered {0} positive numbers, {1} zeros and {2} negative numbers",positiveNumber, zero, negativeNumber);
            */

            //--------------------------------------------------------

            /*
            //h
            //we need to find out octal of a decimal integer entered by the user
            // for finding the octal of any decimal, first we have to succesively divide and find the remainders of the number as shown below.
            //Now we obtain the un-reversed number. Finally reverse the+ number and display.
            int originalNumber, no, res = 0, flag = 0;
            double ten=0, oct = 0; //powers should always be taken in double
            Console.WriteLine("Enter any number");
            originalNumber = Convert.ToInt32(Console.ReadLine());
            no = originalNumber;

            while (no!=0)
            {
                //this is the un-reversed number
                res = res * 10 + no % 8; //carrying out successive division of user entered number and storing the remainder in variable 'res'
                if(res == 0) // checking for zero at first position
                 {
                    flag++;
                }
                no = no / 8;
            }

            while (res != 0) //reversing the number
            {
                oct = oct * 10 + res % 10;
                res = res / 10;
            }

            //now if we got the remainder of first itersion as 0, multiple by 10
            if (flag > 0)
            {
                ten = Math.Pow(10, flag);
                oct = oct * ten;
            }
            Console.WriteLine("The octal of {0} is {1}.", originalNumber, oct);
            */

            //--------------------------------------------------------

            /*
            //i
            Console.WriteLine("Part a Question 9");
            //finding the range of number
            int min = -2147483648, max = 2147483647;
            char choice = 'y';

            do
            {
                Console.Write("Enter the number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num > min)
                {
                    min = num;
                }
                if (num < max)
                {
                    max = num;
                }

                //ask user to continue to take the input numbers 
                Console.Write("Do you continue to give numbers (Say y or n):");
                choice = Convert.ToChar(Console.ReadLine());

            } while (choice == 'Y' || choice == 'y');

            Console.WriteLine($"Range is {min - max}");
            
            */
            //--------------------------------------------------------



        }
    }
}
