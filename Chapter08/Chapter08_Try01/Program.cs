/*
 * -----------------------------------------------------------------------------
 * Created by Ulysses Carlos on 02/28/2021 at 09:46 PM
 * 
 * Program.cs
 * Cylinders: A Complete Program. We’re going to create a simple program that 
 * will tell the user interesting information about a cylinder. A cylinder is 
 * usually defined by a height (h) and radius of the base (r). 
 * Create a program that allows the user to type in these two values. We’ll do 
 * some math with those values to figure out the volume of that cylinder, as 
 * well as the surface area. (Don’t worry about the formulas; I’ll 
 * provide them to you.) The program will then output the results to the user.
 * 
 * Volume of a Cylinder: 𝑉 = 𝜋r^2h
 * Surface Area of a Cylinder: 𝑆𝐴 = 2𝜋r(r + h)
 * -----------------------------------------------------------------------------
 */

using System;

namespace Chapter08 {
    public class Program {
        public static void Main(string[] args) {

            Console.WriteLine("Please enter a radius:");
            double radius = Convert.ToDouble(Console.ReadLine());
			
            Console.WriteLine("Now please enter a height:");
            double height = Convert.ToDouble(Console.ReadLine());
			
            double volume = Math.PI * radius * height;
            double surface_area = 2 * Math.PI * radius * (radius + height);

            Console.WriteLine("Volume: " + volume);
            Console.WriteLine("Surface Area: " + surface_area);

            // Also, here's some escape line stuff
            Console.WriteLine("\nNow the same information using string interpolation:" +
                              $"\nVolume: {volume}\nSurface Area: {surface_area}");

        }
    }
}
