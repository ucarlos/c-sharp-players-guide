/*
 * -----------------------------------------------------------------------------
 * Created by Ulysses Carlos on 03/15/2021 at 05:22 PM
 * 
 * Ball.cs
 * The Ball class should have instance variables for size and color
 * (the Color class you just created). Let’s also add an instance variable
 * that keeps track of the number of times it has been thrown.
 *
 * Create any constructors you feel would be useful.
 *
 * Create a Pop method, which changes the ball’s size to 0.
 *
 * Create a Throw method that adds 1 to the throw count, but only if the ball
 * hasn’t been popped (has a size of 0).
 *
 *
 * A method that returns the number of times the ball has been thrown.
 * Write some code in your Main method to create a few balls, throw them
 * around a few times, pop a few, and try to throw them again, and print
 * out the number of times that the balls have been thrown. (Popped balls
 * shouldn’t have changed.)
 * 
 * -----------------------------------------------------------------------------
 */


namespace Color {
    public class Ball {
        //private double size;
        //private int throw_count;
        private Color color;

        public void Pop() { size = 0.0; }

        // Read-Only Auto-Initialized Property
        public int throw_count { get; private set; }

        public void Throw() {
            if (size > 0) 
                throw_count++;
        }
        
        
        // Auto-initialized Property Example
        public double size { get; set; }
        
        // Constructors
        // Default constructor
        public Ball() {
            size = 0;
            color = new Color();
            this.throw_count = 0;
        }

        public Ball(double size, Color color) {
            this.color = new Color(color);
            this.size = size;
            this.throw_count = 0;
        }

        public Ball(double size, byte red_val, byte green_val, byte blue_val) {
            this.size = size;
            this.throw_count = 0;
            this.color = new Color(red_val, green_val, blue_val);
        }

        public Ball(double size, byte red_val, byte green_val, byte blue_val, byte alpha_val) {
            this.size = size;
            this.throw_count = 0;
            this.color = new Color(red_val, green_val, blue_val, alpha_val);
        }
    }
}