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
            //User.ID is the static variable of the User class and can be accessed without even creating an instance of this class.
            Console.WriteLine(User.ID);
            User user1 = new User("Aanand");
            user1.Password = 5;
            Console.WriteLine(user1.Username);
            Console.WriteLine(User.ID);

            User user2 = new User("Andrew");
            user2.Password = 10;
            Console.WriteLine(user2.Username);
            Console.WriteLine(User.ID);

            Console.ReadLine();


        }
    }
}
