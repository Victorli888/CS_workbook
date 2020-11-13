using System;

class CSYB1_GlazerCalc
{
    static void Main()
    {
        double width, height, woodLength, glassArea;
        string widthString, heightString;

        widthString = Console.ReadLine();
        width = double.Parse(widthString);

        heightString = Console.ReadLine();
        height = double.Parse(heightString);

        woodLength = 2 * (width + height) * 3.25;
        glassArea = 2 * (width * height);

        Console.WriteLine("The length of the wood is " + woodLength + " feet");
        Console.WriteLine( "The area of the glass is " + glassArea + " square meters");

    }
}

/* For Learning Purposes lets go through each line to understand each item and it's function

using System;
- tells the compilier to use things from System namespace.
- namespace:  is where particular names have meaning
- Console: class allows for things to be written on screen to be viewed in front of the user
- static: makes sure that the following method is ALWAYS present.
- Void: The method were about to describe does not return anything of interest. Meaning it'll do its job and finish
- Main: There is always one and must always be one, This is where the system knows where to start.
- (): Closed pair of brackets tells the Method Main doesn't have any parameters
- {}: Lumps code blocks and tells the complier that } is the end of that method 
- double: "Double Precision floating number"
- varaible names; width, height woodLength etc
- ; this marks the end of a statement
- Console. : the method is a part of the object, Console which manages user input and output
- . : the full stop dot this seperates the object identifier with the method identifier
- Readline waits for the user to enter a line of text and press the Enter key
- double. perform double precision floating point number on widthString by exposing Parse method
- Parse method - converting the string to a double percision floating point number
- (widthString); - serves as a parameter for Parse method
- 
*/
