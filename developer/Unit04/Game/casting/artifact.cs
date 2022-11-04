using System.Collections.Generic;
using System.IO;
using System;

namespace unit04_greed.Game.Casting
{
    // The responsibility of an Artifact is to provide a message about itself.
    public class Artifact: Actor
    {
        private int score = 0;

        // Constructs a new instance of Artifact.
        public Artifact()
        {
        }
    
        // Gets the artifact's message.
        // Returns the message as a string.
        public int GetScore()
        {
            return score;
        }
    
        // Sets the artifact's message to the given value.
        public void SetScore(int score)
        {
            this.score = score;
        }
    }
}