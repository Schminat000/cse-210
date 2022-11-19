using System;


namespace Unit05_cycle.Game.Casting
{
    public class OneScore : Actor
    {
        private int points = 0;

        public OneScore()
        {
            AddPointsOne(0);
        }

        public void AddPointsOne(int points)
        {
            this.points += points;
            SetText($"Player One: {this.points}");
        }
    }
}