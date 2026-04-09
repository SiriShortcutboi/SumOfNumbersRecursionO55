using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine(Sum(5));
                                     
    } //Finished program, im just gonna be done with the base 
    // level on this one, the other assignment i was spinning
    //  my wheels far too long on bonus content

    static int Sum(int number)
    {
        //Exit case, base case (NEEDS AN EXIT CASE on top of it)
        if (number == 1)
        {
            Console.WriteLine("equals"); 
            return 1;
        }
        else{ //recursive call
        Console.WriteLine(number + " plus");
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