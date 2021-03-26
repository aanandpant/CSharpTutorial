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
            point point = new point();
            int x=point.x = 2;
            int y=point.y = 3;
            Console.WriteLine("value of x=" + x + " and the value of Y=" + y);
            Console.ReadLine();
        }

    }
}
