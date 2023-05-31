using System;

public class Program
{
    // NOT function
    public static bool NOT(bool a)
    {
        if (a == true)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    
    // Main function
    public static void Main(string[] args)
    {
        // Truth Table
        Console.WriteLine("--> False | OFF | 0");
        Console.WriteLine("--> True  | ON  | 1");
        Console.WriteLine();
        Console.WriteLine("--------------------------------");
        Console.WriteLine("|  Truth Table for a NOT gate  |");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("| A = False     | B = " + NOT(false) + "    |");
        Console.WriteLine("| A = True      | B = " + NOT(true) + "   |");
        Console.WriteLine("--------------------------------");
        
        // Notes
        Console.WriteLine();
        Console.WriteLine("* NOT gate output is FALSE if the input is TRUE, and vice versa");
        Console.WriteLine();
        
        Console.Write("Enter a value for input A (0, 1): ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Output B is: " + NOT(a == 1));
    }
}
