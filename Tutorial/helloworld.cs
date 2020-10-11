using System;

namespace Tutorial
{
    class hello_world
    {
        static void Main(string[] args)  // Static - method belongs to "class Program" Void - method will not have a return value
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("This is used for a test commit.");
        }
    }
}

// The Console class is used to represent the standard input, output, and error streams for console applications.
// Use namespace to provide a way to keep one set on names seperate from another. I.e class names declared in one namespace 
// won't be conflict with class names declared in another.