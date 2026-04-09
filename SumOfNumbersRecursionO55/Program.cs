using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine(Sum(5));
                                      
    }

    static int Sum(int number)
    {
        //Exit case, base case (NEEDS AN EXIT CASE on top of it)
        if (number == 1)
        {
            return 1;
        }
        else{ //recursive call
        return number + Sum(number - 1);
        }
    //call stack looks ike this 
    // 5 * Factorial Solver(4)
    // 5 * 4 * Factorial Solver(3)
    // 5 * 4 * 3 * Factorial Solver(2)
    // 5 * 4 * 3 * 2 Factorial Solver(1)
    // 5 * 4 * 3 * 2 * 1
    }

}