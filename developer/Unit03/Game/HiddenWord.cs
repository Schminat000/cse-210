using System;
using System.Collections.Generic;
using System.IO;

namespace unit03_jumper
{
    // Creates the class HiddenWord.
    public class HiddenWord
    {
        public string hiddenword;
        List<char> answer = new List<char>();
        public List<char> guess = new List<char>();

        // Calls the class HiddenWord.
        public HiddenWord()
        {
        }

        // Creates the pullWord function. It takes a word from
        // a list of words in a text file. It randomly chooses one
        // then returns it.
        public string pullWord()
        {
            List<string> lines = new List<string>(File.ReadLines("words.txt"));
            Random rand = new Random();
            int randomIndex = rand.Next(0, lines.Count);
            string chosenWord = lines[randomIndex];
            return chosenWord;
        }

        // Creates the listWord function. Adds the word to the list
        // from the parameter, and makes it lowercase.
        public void listWord(string killWord)
        {
            answer.AddRange(killWord.ToLower());
        }

        // Creates the createHiddenWord function. For each i in
        // answer, it adds a blank spot("_").
        public void createHiddenWord()
        {
            foreach (int i in answer)
            {
                guess.Add('_');
            }
        }

        // Creates the printGuess function. It prints the guess given by
        // the user.
        public void printGuess()
        {
            Console.WriteLine(string.Format("{0}", string.Join(" ", guess)));       
        }

        // Creates the compare function. It takes the number of guesses and
        // the list of previous guesses to compare and see if they are correct.
        public int compare(List<char> listPreviousGuesses, int numberOfGuesses)
        {
            for (int i = 0; i < answer.Count; i++)
            {

                if (listPreviousGuesses.Contains(answer[i]))
                {
                    guess[i] = answer[i];
                }
            }

            if (answer.Contains(listPreviousGuesses[numberOfGuesses - 1]))
            {
                return 0;
            }

            else
            {
                return 1;
            }
        }

        // Prints the answer of the game.
        public void printAnswer()
        {
            Console.WriteLine(string.Format("{0}", string.Join(" ", answer)));
        }
    }
}