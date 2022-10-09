using System;
using System.Collections.Generic;


namespace Unit02.Game
{
    /// <summary>
    /// A person who directs the game. 
    ///
    /// The responsibility of a Director is to control the sequence of play.
    /// </summary>
    public class Director
    {
        List<Deck> _cards = new List<Deck>();
        bool _isPlaying = true;
        int _score = 0;
        int _totalScore = 300;

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
            Deck deck = new Deck();
            _cards.Add(deck);
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            int firstValue = FirstRound();
            while (_isPlaying)
            {
                DoInputs(firstValue);
                DoOutputs();
                PlayAgain();
            }
        }

        /// <summary>
        /// Asks the user if they want to roll.
        /// </summary>
        public void PlayAgain()
        {
            Console.Write("Play again? [y/n] ");
            string playAgain = Console.ReadLine();
            _isPlaying = (playAgain == "y");
            Console.WriteLine();
        }

        /// <summary>
        /// Updates the player's score.
        /// </summary>
        public void DoInputs(int firstValue)
        {
            if (!_isPlaying)
            {
                return;
            }
            
            _score = 0;
            foreach (Deck deck in _cards)
            {
                deck.Card(firstValue);
                _score += deck.points;
            }
            _totalScore += _score;
        }

        /// <summary>
        /// Displays the card and the score. Also asks the player if they want to play again. 
        /// </summary>
        public string DoOutputs()
        {
            if (!_isPlaying)
            {
                return "";
            }

            string value = "";
            foreach (Deck deck in _cards)
            {
                value += $"{deck.value} ";
            }

            Console.WriteLine($"The next card was: {value}");
            Console.WriteLine($"Your score is: {_totalScore}");
            _isPlaying = (_score > 0);

            return value;
        }

        /// <summary>
        /// Displays the game's first round value and returns it to be used.
        /// </summary>
        public int FirstRound()
        {
            Random random = new Random();

            int value = 0;
            for (int i = 1; i < 13; i++)
                value = random.Next(1, 13);

            Console.WriteLine($"The card is: {value}");

            return value;
        }
    }
}


