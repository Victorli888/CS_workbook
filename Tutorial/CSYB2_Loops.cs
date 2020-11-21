// While loops
using System;
using System.Reflection;

class LoopForever
{
    public static void not_Main()
    {
        do
        {
         Console.WriteLine("I love you mum");   
        } while (true);
    }
}

class forloop
{
    public static void not_Main()
    {
        Console.WriteLine("Let's count from 1 to 10");
        int i;
        i = 0;
        while (i <= 10)
        {
            Console.WriteLine(i);
            i = i + 1;
        }
    }
}


/* The Basic Template to writing this loop is:
 
 for (setup; finish test; update)
 {
    Block of code for things I want to do
 }
 
 */
class also_for_loop
{
    public static void Main()
    {
        Console.WriteLine("Let's Count from 1 to 10");
        int i;
        for (i = 1; i < 11; i = i + 1)
        {
            Console.WriteLine(i);
        }
    }
}    

/*
 Use the break statement to break out of loops typically what it will look like is
 
 while (runningOK)
 {
    running block of code
    ....
    if (abort condition)
    {
        break;
    }
    ...
    code that occurs in loop when code is not aborted
}
...
code that occurs outside of the while loop
...
 
 */
 
 
 /* use the continue statement to go back to the top of a loop, such like updating varaibles after running an if code

for ( item = 1 ; item < Total_Items; item = item+1)
{
    ....
    items processing stuff
    ....
    if (Done_for_Now) continue;
    ....
    more code that needs to be run
    ....
}

