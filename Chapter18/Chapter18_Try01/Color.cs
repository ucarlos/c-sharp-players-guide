/*
 * -----------------------------------------------------------------------------
 * Created by Ulysses Carlos on 03/15/2021 at 04:46 PM
 * 
 * Color.cs
 * Create a Color class:
 *
 * On a computer, colors are typically represented with a red, green, blue,
 * and alpha (transparency) value, usually in the range of 0 to 255.
 * Add these as instance variables.
 *
 * A constructor that takes a red, green, blue, and alpha value.
 * A constructor that takes just red, green, and blue, while alpha defaults
 * to 255 (opaque).
 *
 * Methods to get and set the red, green, blue, and alpha values from a
 * Color instance.
 *
 * A method to get the grayscale value for the color, which is the average
 * of the red, green and blue values.
 * -----------------------------------------------------------------------------
 */

namespace Color {
    public class Color {
        private byte red_val;
        private byte green_val;
        private byte blue_val;
        private byte alpha_val;


        public Color() {
            this.red_val = this.green_val = this.blue_val = this.alpha_val = 255;
        }
        public Color(byte red_val, byte green_val, byte blue_val, byte alpha_val) {
            this.red_val = red_val;
            this.green_val = green_val;
            this.blue_val = blue_val;
            this.alpha_val = alpha_val;
        }

        public Color(byte red_val, byte green_val, byte blue_val) {
            this.red_val = red_val;
            this.green_val = green_val;
            this.blue_val = blue_val;
            this.alpha_val = 255;
        }
        
        // Typical setters and getters:
        public byte get_red() { return red_val; }
        public void set_red(byte val) { red_val = val; }
        
        public byte get_blue() { return blue_val; }
        public void set_blue(byte val) {
            blue_val = val;
        }

        public byte get_green() {
            return green_val;
        }

        public void set_green(byte val) {
            green_val = val;
        }

        public byte get_alpha() {
            return alpha_val;
        }

        public void set_alpha(byte val) {
            alpha_val = val;
        }

        public int grayscale() {
            return (blue_val + green_val + red_val) / 3;
        }
    }
}