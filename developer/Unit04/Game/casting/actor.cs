using System;

namespace unit04_greed.Game.Casting
{     
    // Creates the Actor class.
    // The responsibility of Actor is to keep track of its
    // appearance, position and velocity in 2d space.
    public class Actor
    {
        private string text = "";
        private int fontSize = 15;
        private Color color = new Color(255, 255, 255); // white
        private Point position = new Point(0, 0);
        private Point velocity = new Point(0, 0);

        //Constructs a new instance of Actor.
        public Actor()
        {
        }

        // Gets the color and returns it.
        public Color GetColor()
        {
            return color;
        }

        // Gets the font size and returns it.
        public int GetFontSize()
        {
            return fontSize;
        }

        // Get's the actor position and returns it.
        public Point GetPosition()
        {
            return position;
        }

        // Get's the actor's text and returns it.
        public string GetText()
        {
            return text;
        }

        // Gets the actor's velocity and returns it.
        public Point GetVelocity()
        {
            return velocity;
        }

        // Creates a function that will
        // move the actor to its next position according to its velocity.
        // Will wrap the position from one side of the screen to the other
        // when it reaches the maximum x and y values.
        public void MoveNext(int maxX, int maxY)
        {
            int x = ((position.GetX() + velocity.GetX()) + maxX) % maxX;
            int y = ((position.GetY() + velocity.GetY()) + maxY) % maxY;
            position = new Point(x, y);
        }

        // Creates the function SetColor.
        // Sets the actor's color to the given value. With the given
        // parameter.
        public void SetColor(Color color)
        {
            if (color == null)
            {
                throw new ArgumentException("color can't be null");
            }
            this.color = color;
        }

        // Creates the function SetFontSize.
        // Sets the actor's font size to the given value with
        // the given parameter.
        public void SetFontSize(int fontSize)
        {
            if (fontSize <= 0)
            {
                throw new ArgumentException("fontSize must be greater than zero");
            }
            this.fontSize = fontSize;
        }

        // Creates the SetPosition function.
        // Sets the actor's position to the given value with the
        // given parameter.
        public void SetPosition(Point position)
        {
            if (position == null)
            {
                throw new ArgumentException("position can't be null");
            }
            this.position = position;
        }

        // Creates the SetText function.
        // Sets the actor's text to the given value with the
        // set parameter.
        public void SetText(string text)
        {
            if (text == null)
            {
                throw new ArgumentException("text can't be null");
            }
            this.text = text;
        }

        // Creates the SetVelocity function.
        // Sets the actor's velocity to the given value with the
        // given parameter.
        public void SetVelocity(Point velocity)
        {
            if (velocity == null)
            {
                throw new ArgumentException("velocity can't be null");
            }
            this.velocity = velocity;
        }
    }
}