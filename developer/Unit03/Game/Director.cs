using System;
using System.Collections.Generic;

namespace unit03_jumper
{
    // The responsibility of a Director is to control the sequence of play.
    public class Director
    {
        private bool isPlaying = true;
        private string chosenWord;

        private TerminalService terminalService = new TerminalService();
        public HiddenWord hiddenWord = new HiddenWord();
        private Jumper jumper = new Jumper();
        public int tries = 0;
        public int numberOfGuesses = 0;

        private bool checkInput;

        List<char> guessedLetters = new List<char>();

        public string currentGuess = "test";


        // Constructs a new instance of Director.
        public Director()
        {
        }

        // Starts the game by running the main game loop.
        public void StartGame()
        {
            StartUp();

            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        // Creates the StartUp function. It shows the hint and
        // calls different functions from the class to begin the
        // game of guessing!
        private void StartUp()
        {
            Console.WriteLine("\nHint: The Book of Mormon");
            chosenWord = hiddenWord.pullWord();
            hiddenWord.listWord(chosenWord);
            hiddenWord.createHiddenWord();
            hiddenWord.printGuess();
        }

        // Creates the GetInputs function. It displays the jumper
        // man. It is the guessing part of the game and takes that to
        // the next function DoUpdates.
        private void GetInputs()
        {
            Console.WriteLine("\n");
            jumper.printJumper(tries);
            checkInput = true;

            while (checkInput)
            {
                currentGuess = terminalService.ReadGuess("\nGuess a letter [a-z]: ");
                checkInput = jumper.checkInput(guessedLetters, currentGuess);
            }

            guessedLetters.Add(currentGuess[0]);
        }

        // Creates the DoUpdates function. It does the background things to
        // insure that the game is being played right. It says if the game is
        // still going as well.
        private void DoUpdates()
        {
            numberOfGuesses = guessedLetters.Count;
            int usedTries = hiddenWord.compare(guessedLetters, numberOfGuesses);
            tries = tries + usedTries;
            isPlaying = jumper.checkJumper(hiddenWord.guess, tries);
        }

        // Creates the DoOutputs function. It determines if the player is
        // still playing. If so, it asks for the next guess and if not it will
        // prints the answer.
        private void DoOutputs()
        {
            Console.WriteLine("\n");

            if (isPlaying)
            {
                hiddenWord.printGuess();
            }

            else
            {
                jumper.printJumper(tries);
                hiddenWord.printAnswer();
                Console.WriteLine("\n");
            }
        }
    }
}