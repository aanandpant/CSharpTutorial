/* list of namespaces*/
using System;
using PointsAndLines;
using Utility;

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
            //Race is the enumeration datatype that we've defined and has two values: earthling and alien.
            //ConsoleColor is an enumeration;
            //Console is a static class of the System namespace
            Console.ForegroundColor = ConsoleColor.Red;
            User user1 = new User("Aanand",Race.earthling);
            user1.Password = 5;
            Utilities.ColorfulWriteLine(user1.Username, ConsoleColor.Red);
            user1.SayMyName();
            

            Console.WriteLine("This is userID "+user1.id);
            Console.WriteLine(user1.race);

            User user2 = new User("Andrew",Race.alien);
            user2.Password = 10;
            Console.WriteLine(user2.Username);
            Console.WriteLine("This is userID " + user2.id);

            Console.WriteLine("There are currently " + User.currentID + " users in the system");
            //user2.WEIGHT = 34; will throw an error since it's a constant and cannot be set
            Console.ReadLine();


        }
    }
}
