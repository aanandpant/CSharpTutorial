/* list of namespaces*/
using System;
using PointsAndLines;

namespace CsharpTutorial
{

    /*
    class point
    {
        public int x;
        public int y;
    }*/
    class testCode
    {
        /*static keyword is used to call a method before class instantiation, which means that you can call a function without creating the object of that class.*/
        static void Main()
        {
            point point2 = new point();
            point point = new point(5,10);
            int x=point2.X = 2;
            int y=point2.Y = 3;
            Console.WriteLine("The value of point x=" + x + " and Y=" + y);
            Console.WriteLine("The value of point x=" + point.X + " and Y=" + point.Y);
            //Console.WriteLine("value of x=" + x + " and the value of Y=" + y);

            Console.ReadLine();
        }
    }
}
