using System.Collections.Generic;


namespace unit04_greed.Game.Casting
{
    // Creates the class called Color.
    // The responsibility of Color is to hold and provide information about itself. Color has 
    // a few convenience methods for comparing and converting them.
    public class Color
    {
        private int red = 0;
        private int green = 0;
        private int blue = 0;
        private int alpha = 255;

        // Constructs a new instance of Color using the given red, green and blue values.
        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        // Gets the color's alpha value.
        // Returns the alpha value.
        public int GetAlpha()
        {
            return alpha;
        }

        // Gets the color's blue value.
        // Returns the blue value.
        public int GetBlue()
        {
            return blue;
        }

        // Gets the color's green value.
        // Returns the green value.
        public int GetGreen()
        {
            return green;
        }

        // Gets the color's red value.
        // Returns the red value.</returns>
        public int GetRed()
        {
            return red;
        }
    }
}