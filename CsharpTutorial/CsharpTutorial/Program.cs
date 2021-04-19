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
    class Testcode
    {
        /*static keyword is used to call a method before class instantiation, which means that you can call a function without creating the object of that class.*/
        static void Main()
        {
            User user = new User("Aanand");
            user.Password = 5;
            Console.WriteLine(user.Username);
            Console.ReadLine();


        }
    }
}
