//using System;
//class Test
//{
//    static void Main()
//    {
//        double x = 3.0, y = 2.0;
//        int a = 10, b = 2;

//        Console.ReadLine();
//    }
//}

/*
 * Notice that line 8 is blank.  Now fill the blank with each of the statements listed in the table
 * below, one at a time.  Run the program and put the result in the right column.
 * 
 * Statement                            Result
 * Console.WriteLine(a)                 10
 * Console.WriteLine(x+a)               13
 * Console.WriteLine(a/b)               5
 * Console.WriteLine(y/x)               0.66666667
 * Console.WriteLine(y%x)               2
 * Console.WriteLine(a+b)/b%a           6
 * Console.WriteLine(9.0/5.0*(a-x))     12.6
 * Console.WriteLine(x+y-x*y%x)         5
 * Console.WriteLine(57%50/25)          0
 */

using System;
class Test
{
    static void Main()
    {
        double x = 3.0, y = 2.0;
        int a = 10, b = 2;
        Console.WriteLine(a);
        Console.WriteLine(x + a);
        Console.WriteLine(a / b);
        Console.WriteLine(y / x);
        Console.WriteLine(y % x);
        Console.WriteLine((a + b) / b % a);
        Console.WriteLine(9.0 / 5.0 * (a - x));
        Console.WriteLine(x + y - x * y % x);
        Console.WriteLine(57 % 50 / 25);
        Console.ReadLine(); 
    }
}
