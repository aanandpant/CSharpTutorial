//static class cannot contain a constructor, since it can't be used to create an object.
using System;

namespace Utility
{
    static class Utilities
    {

        public static void ColorfulWriteLine(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();

        }

    }
}