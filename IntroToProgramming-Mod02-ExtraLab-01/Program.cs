/*
 * Consider the following incomplete code
 */
//using System;

//class SayHi
//{
//    static void Main()
//    {
//        string yourName = ___(1) ___;
//        uint yourAge = ___(2) ___;
//        Console.WriteLine(" Hello {1}. You are {0} years old . ",
//        ___(3) ___, ___(4) ___);
//    }
//}

/*
 * Fill in the blanks (1),..., (4) so that the program will say hello to you and print out your own age.  For 
 * example, if your name is "Arthur" and you are 18 years old, the result should be:  Hello Arthur.  You are 
 * 18 years old.
 */

using System;

class SayHi
{
    static void Main()
    {
        string yourName = "David";
        uint yourAge = 25;
        Console.WriteLine(" Hello {1}. You are {0} years old . ",
        yourAge, yourName);

        Console.ReadLine();
    }
}

// OUTPUT:  Hello David. You are 25 years old .