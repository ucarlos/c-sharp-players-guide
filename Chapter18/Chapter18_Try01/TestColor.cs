using System;

namespace Color {
    class Program {
        public static void Main(string[] args) {
            // Make an instance of type Color;
            // navajo white ball
            Ball ball1 = new Ball(10, new Color(255, 222, 173));
            Ball ball2 = new Ball(100.4, 255, 255, 255);
            Ball ball3 = new Ball(50, 20, 40, 60, 80);
            
            ball1.Throw();
            ball1.Throw();
            ball1.Throw();
            ball1.Throw(); // Should be 4

            ball2.Throw();
            ball2.Pop();
            ball2.Throw(); // Should be 1

            ball3.Throw();
            ball3.Throw();
            ball3.Throw();
            ball3.Throw();
            ball3.Throw();
            ball3.Throw();
            ball3.Throw(); // Should be 7:
            
            // Now print their sizes:
            Console.WriteLine($"Ball 1: \tSize: {ball1.size}\tThrown {ball1.throw_count} time(s)");
            Console.WriteLine($"Ball 2: \tSize: {ball2.size}\tThrown {ball2.throw_count} time(s)");
            Console.WriteLine($"Ball 3: \tSize: {ball3.size}\tThrown {ball3.throw_count} time(s)");

        }
    }
}