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
            User user1 = new User("Aanand");
            user1.Password = 5;
            Console.WriteLine(user1.Username);
            Console.WriteLine("This is userID "+user1.id) ;

            User user2 = new User("Andrew");
            user2.Password = 10;
            Console.WriteLine(user2.Username);
            Console.WriteLine("This is userID " + user2.id);

            Console.WriteLine("There are currently " + User.currentID + " users in the system");
            //user2.WEIGHT = 34; will throw an error since it's a constant and cannot be set
            Console.ReadLine();


        }
    }
}
