//Program 1
//Demonstration of Classes and Objects

using System;
namespace chapter7_ClassesN_Objects_Program1
{
    class Rectangle
    {
        private int len, br;

        public void GetData()
        {
            Console.WriteLine("Enter length and breadth of your rectangle");
            len = Convert.ToInt32(Console.ReadLine());
            br = Convert.ToInt32(Console.ReadLine());
        }

        public void SetData(int l, int b) //parameters are directly passed from the main class
        {
            len = l;
            br = b;
        }

        public void DisplayData()
        {
            Console.WriteLine("Length = {0}, breadth = {1}", len, br);
        }

        public void AreaPer()
        {
            int a, p;
            a = len * br;
            p = 2 * (len + br);
            Console.WriteLine("Area of the rectangle = {0}, Perimeter of the rectanglr={1}", a, p);
        }
    }

    class classesAndObjects
    {
        static void Main(string[] args)
        {
            Rectangle r1, r2, r3; // defining three references
            r1 = new Rectangle();
            r2 = new Rectangle();
            r3 = new Rectangle();

            r1.SetData(10, 20);
            r1.DisplayData();
            r1.AreaPer();

            r2.GetData();
            r2.AreaPer();

            r3.DisplayData();
            r3.AreaPer();
        }
    }
}
