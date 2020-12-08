/* I have some math problems to do for school so instead of doing them all by hand
 lets write a script program that will do all the calculations for me!
 10*10, 5+5, 6-6
 */

using System;

class mathHW
{
    static int returnplus(int i)
    {
        i += 1;
        return i;
    }

    static int returnminus(int i)
    {
        i -= 1;
        return i;
    }

    static int returnmult(int i)
    {
        i *= 1;
        return i;
    }
    // We have our methods to do our homework now lets use them to calculate and print our results

    public static void Main()
    {
        // 10*10 = ans1 ; 5+5 = ans2 ; 6-6 = ans3
        int ans1 = returnmult(10);
        int ans2 = returnplus(5);
        int ans3 = returnminus(6);
        int[] ansArr = {ans1, ans2, ans3};
        int questionNum = 1;
        foreach (int ans in ansArr)
        {
            Console.WriteLine("Question {questionNum}: " + ans);
            questionNum += 1;
        }
            

    }
}

/* 
Main Ideas:  Arrays, PlaceHolder Print statements for neater printing, foreach loop,  multiple method creation
Use foreach to loop through elements in an array
*/