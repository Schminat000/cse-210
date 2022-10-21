using System;
using System.Collections.Generic;

namespace unit03_jumper
{
    // Creates the Jumper class. It visually represents the jumper.
    public class Jumper{
        private List<string> jumper = new List<string>();
        private int count;
        private int trueTries = 0;

        // Displays the jumper graphics.
        public Jumper()
        {
            jumper.Add("  ___");
            jumper.Add(" /___\\");
            jumper.Add(" \\   /");
            jumper.Add("  \\ /");
            jumper.Add("   O");
            jumper.Add("  /|\\");
            jumper.Add("  / \\");
            jumper.Add("");
            jumper.Add("^^^^^^^");
        }

        // Creates the printJumper function. Takes the tries
        // and tells when to remove a line from the parachute.
        public void printJumper(int tries)
        {
            if (tries == trueTries)
            {
            }

            else if(tries == 4)
            {
                jumper.RemoveRange(0, 1);
                jumper[0] = "   X";
            }

            else
            {
                jumper.RemoveRange(0, 1);
                trueTries++;
            }
            
            Console.WriteLine(string.Format("{0}", string.Join("\n", jumper)));
        }

        // Creates the checkJumper function. Takes the wordGuess and tries
        // parameters. It will return true or false depending on the results.
        public bool checkJumper(List<char> wordGuess, int tries)
        {
            count = 0;

            for (int i = 0; i < wordGuess.Count; i++)
            {
                if (wordGuess[i] != '_')
                {
                    count++;
                }
            }

            if (count == wordGuess.Count)
            {
                return false;
            }

            else if (tries == 4)
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        // Creates the checkInput function. Takes the number of guesses and
        // the currentguess. Depending on the results, returns true or
        public bool checkInput(List<char> guesses, string currentguess)
        {
            if (guesses.Contains(currentguess[0]))
            {
                Console.WriteLine("You already guessed that letter!");
                return true;
            }

            else
            {
                return false;
            }

        }
    }
}