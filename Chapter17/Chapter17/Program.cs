/*
 * ------------------------------------------------------------------------------
 * Created by Ulysses Carlos on 03/13/2021 at 09:53 PM
 * 
 * Program.cs
 * Die Rolling. Tons of games use dice. The Random class gives us the ability to
 * simulate die rolling. Many games give the player the task of rolling multiple
 * six-sided dice and adding up the results.
 
 * We’re going to write a program that makes life easier for the player of a
 * game like this.  Start the program off by asking the player to type in a
 * number of dice to roll. Create a new Random object and use the Random.Next
 * method to simulate that many die rolls. Add the total up and print the
 * result to the user. (You should only need one Random object for this.)
 * For bonus points, keep looping and handle new numbers until they enter “quit”
 * or “exit.”
 * ------------------------------------------------------------------------------
 */
using System;

namespace Chapter17 {
    public class Program {
        
        public static void Main(string[] args) {
            Random rand = new Random();
            Console.Write("How many dice you want to roll? ");
            int result = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < result; i++) {
                sum += (rand.Next(6) + 1);
            }
            Console.WriteLine($"Total Sum: {sum}");
            string input = "";
            do {
                Console.Write("Would you like to continue? [yes/no] ");
                input = Convert.ToString(Console.ReadLine());
                input = input.ToLower();
                if (input == "no")
                    break;
                
                sum += (rand.Next(6) + 1);
                Console.WriteLine($"Total Sum: {sum}");
                
            } while (input != "no");

            Console.WriteLine("Complete.");
        }
    }
}
