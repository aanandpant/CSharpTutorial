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
            point point1 = new point();
            point point2 = new point(1, 2);
            point1.X = 5;
            point1.Y = 10;
            Console.WriteLine("x=" + point1.X + " y=" + point1.Y);
            Console.WriteLine("x=" + point2.X+ " y=" + point2.Y);
            Console.ReadLine();

        }
    }
}
