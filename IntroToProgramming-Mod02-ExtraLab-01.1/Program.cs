//using System;
//class ComputeArea
//{
//    static void Main()
//    {
//        const double PI = 3.1415926535;
//        radius = 12.5;
//        area = PI * radius * radius;
//        Console.WriteLine(" Circle area = {0} ", area);
//    }
//}

/*
 * The code above does not compile.  
 * 
 * What errors are reported, and at which lines?
 *      * The name 'radius' does not exist in the current context - Line 7
 *      * The name 'area' does not exist in the current context - Line 8
 *      
 * What do you think is the cause?
 *      * The variables radius and area are not declared before they are used.
 *      
 * Fix the code so that it compiles and runs.
 *      * See code below
 *      
 * How did you fix the errors?
 *      * Declared radius and area as data type double
 */

using System;
class ComputeArea
{
    static void Main()
    {
        const double PI = 3.1415926535;
        double radius = 12.5;
        double area = PI * radius * radius;
        Console.WriteLine(" Circle area = {0} ", area);
    }
}
