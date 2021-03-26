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
            int x=point2.x = 2;
            int y=point2.y = 3;
            Console.WriteLine("The value of point x=" + x + " and Y=" + y);
            Console.WriteLine("The value of point x=" + point.x + " and Y=" + point.y);
            //Console.WriteLine("value of x=" + x + " and the value of Y=" + y);

            Console.ReadLine();
        }
    }
}
