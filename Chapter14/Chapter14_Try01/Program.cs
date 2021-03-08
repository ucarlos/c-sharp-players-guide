/*
 * -----------------------------------------------------------------------------
 * Created by Ulysses Carlos on 03/08/2021 at 01:08 AM
 * 
 * Program.cs
 * Months of the Year. Using the DaysOfWeek enumeration as an example, create 
 * an enumeration to represent the months of the year. Assign them the values 
 * 1 through 12. Write a program to ask the user for a number between 1 and 12. 
 *
 * Check to be sure that they gave you a value in the right range and use an 
 * explicit cast to convert the number to your month enumeration. Then, 
 * using a switch statement or if statement to print out the full name of 
 * the month they entered.
 * -----------------------------------------------------------------------------
 */


using System;

namespace Chapter14_Try01 {
    public class Program {

        public enum MonthList {
            January = 1, February, March, April, May, June, July, August, September, October, November, December
        };
        
        public static void Main(string[] args) {
            int val;
            Console.WriteLine("Please enter a number between 1 and 12:");
            val = Convert.ToInt32(Console.ReadLine());
            while (!(1 <= val && val <= 12)) {
                Console.WriteLine("Invalid Input. Please make sure that"
                                  + " the number is between 1 and 12.");
                val = Convert.ToInt32(Console.ReadLine());
            }

			// Now try to assign the enum:
            MonthList month_list = (MonthList) val;
            Console.WriteLine("Month Name: " + month_list);

        }
    }
}
